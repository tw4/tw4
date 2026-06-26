"use client";

import { useState } from "react";
import type { TableData } from "@/lib/api";

const PAGE_SIZE_OPTIONS = [10, 20, 30, 50, 100, 200];

interface DataGridProps {
  tableName: string;
  data: TableData | null;
  loading: boolean;
  page: number;
  pageSize: number;
  onPageChange: (page: number) => void;
  onPageSizeChange: (size: number) => void;
  exportUrl?: string;
}

function formatValue(value: unknown): { text: string; isNull: boolean; isDate: boolean } {
  if (value === null || value === undefined) {
    return { text: "null", isNull: true, isDate: false };
  }
  if (typeof value === "boolean") {
    return { text: value ? "true" : "false", isNull: false, isDate: false };
  }
  if (
    typeof value === "string" &&
    value.length >= 10 &&
    /^\d{4}-\d{2}-\d{2}/.test(value)
  ) {
    try {
      const d = new Date(value);
      return {
        text: d.toLocaleString("tr-TR", { dateStyle: "short", timeStyle: "short" }),
        isNull: false,
        isDate: true,
      };
    } catch {
      return { text: value, isNull: false, isDate: false };
    }
  }
  return { text: String(value), isNull: false, isDate: false };
}

function CellModal({ colName, value, onClose }: { colName: string; value: string; onClose: () => void }) {
  return (
    <div
      className="fixed inset-0 z-50 flex items-center justify-center bg-black/40 p-6"
      onClick={onClose}
    >
      <div
        className="bg-white rounded-xl shadow-2xl max-w-2xl w-full max-h-[80vh] flex flex-col"
        onClick={e => e.stopPropagation()}
      >
        <div className="flex items-center justify-between px-5 py-3 border-b border-slate-200">
          <span className="font-semibold text-slate-700 font-mono text-sm">{colName}</span>
          <button onClick={onClose} className="text-slate-400 hover:text-slate-600 text-lg leading-none">✕</button>
        </div>
        <div className="flex-1 overflow-auto p-5">
          <pre className="text-xs text-slate-800 whitespace-pre-wrap break-all font-mono leading-relaxed">{value}</pre>
        </div>
        <div className="px-5 py-3 border-t border-slate-100 flex justify-end gap-2">
          <button
            onClick={() => navigator.clipboard.writeText(value)}
            className="px-3 py-1.5 text-xs bg-blue-600 text-white rounded-lg hover:bg-blue-700 transition-colors"
          >
            Kopyala
          </button>
          <button
            onClick={onClose}
            className="px-3 py-1.5 text-xs bg-slate-200 text-slate-700 rounded-lg hover:bg-slate-300 transition-colors"
          >
            Kapat
          </button>
        </div>
      </div>
    </div>
  );
}

export default function DataGrid({
  tableName,
  data,
  loading,
  page,
  pageSize,
  onPageChange,
  onPageSizeChange,
  exportUrl,
}: DataGridProps) {
  const hasMore = data?.rows.length === pageSize;
  const [modal, setModal] = useState<{ col: string; value: string } | null>(null);
  const [exporting, setExporting] = useState(false);

  const handleExport = () => {
    if (!exportUrl) return;
    setExporting(true);
    const a = document.createElement('a');
    a.href = exportUrl;
    a.download = `${tableName}.csv`;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    // İndirme başladıktan kısa süre sonra spinner'ı kaldır
    setTimeout(() => setExporting(false), 3000);
  };

  return (
    <div className="flex flex-col h-full bg-white">
      {modal && (
        <CellModal
          colName={modal.col}
          value={modal.value}
          onClose={() => setModal(null)}
        />
      )}

      {/* Toolbar */}
      <div className="flex items-center justify-between px-5 py-3 border-b border-slate-200 shrink-0 bg-white">
        <div className="flex items-center gap-3">
          <h2 className="font-semibold text-slate-800 font-mono text-sm">{tableName}</h2>
          {data && (
            <span className="text-[11px] text-slate-500 bg-slate-100 px-2 py-0.5 rounded-full">
              {data.columns.length} kolon
            </span>
          )}
        </div>

        <div className="flex items-center gap-3">
          {data && (
            <span className="text-xs text-slate-400">
              Sayfa <span className="font-medium text-slate-600">{page}</span>
              {" · "}
              <span className="font-medium text-slate-600">{data.rows.length}</span> satır
            </span>
          )}
          <div className="flex items-center gap-1.5">
            <span className="text-xs text-slate-400">Satır/sayfa:</span>
            <select
              value={pageSize}
              onChange={(e) => onPageSizeChange(Number(e.target.value))}
              className="text-xs text-slate-700 border border-slate-200 rounded-lg px-2 py-1.5 bg-white focus:outline-none focus:ring-2 focus:ring-blue-500 cursor-pointer"
            >
              {PAGE_SIZE_OPTIONS.map((n) => (
                <option key={n} value={n}>{n}</option>
              ))}
            </select>
          </div>
          {exportUrl && (
            <button
              onClick={handleExport}
              disabled={exporting}
              className="flex items-center gap-1.5 px-3 py-1.5 text-xs font-medium bg-emerald-600 text-white rounded-lg hover:bg-emerald-700 disabled:opacity-60 transition-colors"
            >
              {exporting ? (
                <svg className="w-3 h-3 animate-spin" fill="none" viewBox="0 0 24 24">
                  <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4"/>
                  <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8v8z"/>
                </svg>
              ) : (
                <svg className="w-3 h-3" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}>
                  <path strokeLinecap="round" strokeLinejoin="round" d="M4 16v1a3 3 0 003 3h10a3 3 0 003-3v-1m-4-4l-4 4m0 0l-4-4m4 4V4" />
                </svg>
              )}
              {exporting ? "Hazırlanıyor..." : "Excel İndir"}
            </button>
          )}

          <div className="flex gap-1">
            <button
              onClick={() => onPageChange(page - 1)}
              disabled={page <= 1 || loading}
              className="flex items-center gap-1 px-3 py-1.5 text-xs font-medium border border-slate-200 rounded-lg hover:bg-slate-50 disabled:opacity-40 disabled:cursor-not-allowed transition-colors text-slate-600"
            >
              <svg className="w-3 h-3" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2.5}>
                <path strokeLinecap="round" strokeLinejoin="round" d="M15 19l-7-7 7-7" />
              </svg>
              Önceki
            </button>
            <button
              onClick={() => onPageChange(page + 1)}
              disabled={!hasMore || loading}
              className="flex items-center gap-1 px-3 py-1.5 text-xs font-medium border border-slate-200 rounded-lg hover:bg-slate-50 disabled:opacity-40 disabled:cursor-not-allowed transition-colors text-slate-600"
            >
              Sonraki
              <svg className="w-3 h-3" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2.5}>
                <path strokeLinecap="round" strokeLinejoin="round" d="M9 5l7 7-7 7" />
              </svg>
            </button>
          </div>
        </div>
      </div>

      {/* Content */}
      <div className="flex-1 overflow-auto">
        {loading ? (
          <div className="flex flex-col items-center justify-center h-full gap-3 text-slate-400">
            <div className="w-8 h-8 border-2 border-slate-200 border-t-blue-500 rounded-full animate-spin" />
            <p className="text-sm">Veriler yükleniyor...</p>
          </div>
        ) : !data ? null : data.rows.length === 0 ? (
          <div className="flex items-center justify-center h-full">
            <div className="text-center text-slate-400">
              <p className="text-sm font-medium">Bu tabloda veri yok</p>
              <p className="text-xs mt-1">Sayfa {page} boş</p>
            </div>
          </div>
        ) : (
          <table className="w-full text-xs border-collapse">
            <thead className="sticky top-0 z-10">
              <tr className="bg-slate-50 shadow-sm">
                {data.columns.map((col) => (
                  <th
                    key={col.name}
                    className="text-left px-3 py-2.5 font-medium text-slate-500 border-b border-r border-slate-200 whitespace-nowrap bg-slate-50"
                  >
                    <span className="block text-slate-700 font-semibold text-[11px]">{col.name}</span>
                    <span className="block text-[9px] font-mono text-slate-400 mt-0.5">{col.type}</span>
                  </th>
                ))}
              </tr>
            </thead>
            <tbody>
              {data.rows.map((row, rowIdx) => (
                <tr
                  key={rowIdx}
                  className={`group ${rowIdx % 2 === 0 ? "bg-white" : "bg-slate-50/40"} hover:bg-blue-50/30 transition-colors`}
                >
                  {data.columns.map((col) => {
                    const { text, isNull, isDate } = formatValue(row[col.name]);
                    const isLong = !isNull && text.length > 40;
                    return (
                      <td
                        key={col.name}
                        className={`px-3 py-2 border-b border-r border-slate-100 max-w-[220px] ${isLong ? "cursor-pointer hover:bg-yellow-50" : ""}`}
                        title={isNull || isLong ? undefined : text}
                        onClick={isLong ? () => setModal({ col: col.name, value: text }) : undefined}
                      >
                        {isNull ? (
                          <span className="text-slate-300 italic">∅</span>
                        ) : isLong ? (
                          <span className="flex items-center gap-1">
                            <span className={`block truncate ${isDate ? "text-violet-600 font-mono" : "text-slate-700"}`}>
                              {text}
                            </span>
                            <span className="shrink-0 text-blue-400 text-[10px]">↗</span>
                          </span>
                        ) : (
                          <span className={`block truncate ${isDate ? "text-violet-600 font-mono" : "text-slate-700"}`}>
                            {text}
                          </span>
                        )}
                      </td>
                    );
                  })}
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    </div>
  );
}
