"use client";

import { useState, useEffect, useCallback } from "react";
import { fetchTables, fetchTableData, getExportUrl } from "@/lib/api";
import type { TableInfo, TableData } from "@/lib/api";
import TableSidebar from "@/components/TableSidebar";
import DataGrid from "@/components/DataGrid";

const ENVS = {
  Dev:   process.env.NEXT_PUBLIC_DEV_API_URL    ?? "http://localhost:5092",
  Prod:  process.env.NEXT_PUBLIC_PROD_API_URL   ?? "http://localhost:5074",
  SapQA: process.env.NEXT_PUBLIC_SAP_QA_API_URL ?? "http://localhost:5175",
} as const;

type EnvKey = keyof typeof ENVS;

const ENV_STYLES: Record<EnvKey, string> = {
  Dev:   "bg-white text-slate-900 shadow-sm",
  Prod:  "bg-orange-500 text-white shadow-sm",
  SapQA: "bg-emerald-500 text-white shadow-sm",
};

export default function HomePage() {
  const [env, setEnv] = useState<EnvKey>("Dev");
  const [tables, setTables] = useState<TableInfo[]>([]);
  const [selectedTable, setSelectedTable] = useState<string | null>(null);
  const [tableData, setTableData] = useState<TableData | null>(null);
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(50);
  const [filter, setFilter] = useState("");
  const [loading, setLoading] = useState(false);
  const [tablesLoading, setTablesLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const baseUrl = ENVS[env];

  useEffect(() => {
    setTables([]);
    setSelectedTable(null);
    setTableData(null);
    setPage(1);
    setError(null);
    setTablesLoading(true);

    fetchTables(baseUrl)
      .then(setTables)
      .catch((e: Error) => setError(e.message))
      .finally(() => setTablesLoading(false));
  }, [baseUrl]);

  const loadTableData = useCallback(
    async (tableName: string, p: number, ps: number, f: string) => {
      setLoading(true);
      setError(null);
      try {
        const data = await fetchTableData(baseUrl, tableName, p, ps, f || undefined);
        setTableData(data);
      } catch (e: unknown) {
        setError(e instanceof Error ? e.message : "Bilinmeyen hata");
      } finally {
        setLoading(false);
      }
    },
    [baseUrl]
  );

  const handleSelectTable = (name: string) => {
    setSelectedTable(name);
    setPage(1);
    setFilter("");
    setTableData(null);
    loadTableData(name, 1, pageSize, "");
  };

  const handlePageChange = (newPage: number) => {
    if (!selectedTable || newPage < 1) return;
    setPage(newPage);
    loadTableData(selectedTable, newPage, pageSize, filter);
  };

  const handlePageSizeChange = (size: number) => {
    setPageSize(size);
    setPage(1);
    if (selectedTable) loadTableData(selectedTable, 1, size, filter);
  };

  const handleFilter = (e: React.FormEvent) => {
    e.preventDefault();
    if (!selectedTable) return;
    setPage(1);
    loadTableData(selectedTable, 1, pageSize, filter);
  };

  return (
    <div className="flex flex-col h-screen">
      {/* Header */}
      <header className="flex items-center justify-between px-5 py-3 bg-slate-900 text-white shrink-0 border-b border-slate-800">
        <div className="flex items-center gap-4">
          <div className="flex items-center gap-2">
            <div className="w-6 h-6 bg-blue-500 rounded flex items-center justify-center">
              <svg className="w-3.5 h-3.5 text-white" fill="currentColor" viewBox="0 0 20 20">
                <path d="M3 4a1 1 0 000 2h14a1 1 0 000-2H3zM3 8a1 1 0 000 2h14a1 1 0 000-2H3zM3 12a1 1 0 000 2h14a1 1 0 000-2H3z" />
              </svg>
            </div>
            <span className="font-semibold text-sm">OTX Admin</span>
          </div>
          <span className="text-slate-500 text-xs">SAP HANA Database Browser</span>
        </div>

        <div className="flex items-center gap-3">
          {error && (
            <span className="text-red-400 text-xs max-w-xs truncate" title={error}>
              ⚠ {error}
            </span>
          )}
          <div className="flex bg-slate-800 rounded-lg p-0.5 gap-0.5">
            {(Object.keys(ENVS) as EnvKey[]).map((key) => (
              <button
                key={key}
                onClick={() => setEnv(key)}
                className={`px-4 py-1.5 rounded-md text-xs font-semibold transition-all flex items-center gap-1.5 ${
                  env === key ? ENV_STYLES[key] : "text-slate-400 hover:text-slate-200"
                }`}
              >
                {env === key && key !== "Dev" && (
                  <span className="w-1.5 h-1.5 bg-white/60 rounded-full animate-pulse" />
                )}
                {key}
              </button>
            ))}
          </div>
        </div>
      </header>

      {/* Body */}
      <div className="flex flex-1 overflow-hidden">
        <TableSidebar
          tables={tables}
          selectedTable={selectedTable}
          onSelect={handleSelectTable}
          loading={tablesLoading}
        />

        <main className="flex-1 overflow-hidden">
          {!selectedTable ? (
            <div className="flex flex-col items-center justify-center h-full gap-4 text-slate-400 bg-slate-50/50">
              <div className="p-5 bg-white rounded-2xl border border-slate-200 shadow-sm">
                <svg
                  className="w-10 h-10 text-slate-300 mx-auto"
                  fill="none"
                  viewBox="0 0 24 24"
                  stroke="currentColor"
                  strokeWidth={1.5}
                >
                  <path strokeLinecap="round" strokeLinejoin="round" d="M20 7l-8-4-8 4m16 0l-8 4m8-4v10l-8 4m0-10L4 7m8 4v10M4 7v10l8 4" />
                </svg>
              </div>
              <div className="text-center">
                <p className="text-sm font-medium text-slate-500">Görüntülemek için bir tablo seçin</p>
                {!tablesLoading && tables.length > 0 && (
                  <p className="text-xs mt-1 text-slate-400">
                    {env} — <span className="font-medium">{tables.length.toLocaleString()}</span> tablo mevcut
                  </p>
                )}
                {tablesLoading && (
                  <p className="text-xs mt-1 text-slate-400">Tablolar yükleniyor...</p>
                )}
              </div>
            </div>
          ) : (
            <div className="flex flex-col h-full">
              <form onSubmit={handleFilter} className="flex items-center gap-2 px-4 py-2 bg-white border-b border-slate-200 shrink-0">
                <input
                  type="text"
                  value={filter}
                  onChange={e => setFilter(e.target.value)}
                  placeholder="Satır ara... (string kolonlarda LIKE arama)"
                  className="flex-1 text-sm text-slate-900 placeholder-slate-400 border border-slate-300 rounded-lg px-3 py-1.5 focus:outline-none focus:ring-2 focus:ring-blue-500"
                />
                <button type="submit" className="px-3 py-1.5 text-sm bg-blue-600 text-white rounded-lg hover:bg-blue-700 transition-colors">
                  Ara
                </button>
                {filter && (
                  <button
                    type="button"
                    onClick={() => { setFilter(""); if (selectedTable) loadTableData(selectedTable, 1, pageSize, ""); setPage(1); }}
                    className="px-3 py-1.5 text-sm bg-slate-200 text-slate-700 rounded-lg hover:bg-slate-300 transition-colors"
                  >
                    Temizle
                  </button>
                )}
              </form>
              <DataGrid
                tableName={selectedTable}
                data={tableData}
                loading={loading}
                page={page}
                pageSize={pageSize}
                onPageChange={handlePageChange}
                onPageSizeChange={handlePageSizeChange}
                exportUrl={env === "SapQA" ? getExportUrl(baseUrl, selectedTable, filter || undefined) : undefined}
              />
            </div>
          )}
        </main>
      </div>
    </div>
  );
}
