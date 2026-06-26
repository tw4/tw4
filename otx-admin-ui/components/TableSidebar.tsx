"use client";

import { useState, useEffect, useRef, useCallback } from "react";
import type { TableInfo } from "@/lib/api";

const PAGE_SIZE = 100;

interface TableSidebarProps {
  tables: TableInfo[];
  selectedTable: string | null;
  onSelect: (name: string) => void;
  loading?: boolean;
}

export default function TableSidebar({ tables, selectedTable, onSelect, loading = false }: TableSidebarProps) {
  const [search, setSearch] = useState("");
  const [visibleCount, setVisibleCount] = useState(PAGE_SIZE);
  const sentinelRef = useRef<HTMLDivElement>(null);

  const filtered = search
    ? tables.filter((t) => t.name.toLowerCase().includes(search.toLowerCase()))
    : tables;

  const visible = filtered.slice(0, visibleCount);
  const hasMore = visibleCount < filtered.length;

  // Arama değişince listeyi başa sar
  useEffect(() => {
    setVisibleCount(PAGE_SIZE);
  }, [search]);

  // Sentinel göründüğünde daha fazla yükle
  const handleIntersect = useCallback(
    (entries: IntersectionObserverEntry[]) => {
      if (entries[0].isIntersecting && hasMore) {
        setVisibleCount((c) => c + PAGE_SIZE);
      }
    },
    [hasMore]
  );

  useEffect(() => {
    const el = sentinelRef.current;
    if (!el) return;
    const observer = new IntersectionObserver(handleIntersect, { threshold: 0.1 });
    observer.observe(el);
    return () => observer.disconnect();
  }, [handleIntersect]);

  return (
    <aside className="w-64 flex flex-col border-r border-slate-200 bg-slate-50 shrink-0">
      {/* Arama */}
      <div className="p-3 border-b border-slate-200 bg-white">
        <div className="relative">
          <svg
            className="absolute left-3 top-1/2 -translate-y-1/2 w-3.5 h-3.5 text-slate-400"
            fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth={2}
          >
            <path strokeLinecap="round" strokeLinejoin="round" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z" />
          </svg>
          <input
            type="text"
            placeholder="Tablo ara..."
            value={search}
            onChange={(e) => setSearch(e.target.value)}
            className="w-full pl-8 pr-3 py-2 text-sm text-slate-900 placeholder-slate-400 border border-slate-200 rounded-lg bg-slate-50 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent focus:bg-white transition-colors"
          />
        </div>
        {search && (
          <p className="text-[11px] text-slate-400 mt-1.5 px-0.5">
            {filtered.length.toLocaleString()} eşleşme
          </p>
        )}
      </div>

      {/* Liste */}
      <div className="flex-1 overflow-y-auto">
        {loading ? (
          <div className="p-6 text-center">
            <div className="w-8 h-8 border-2 border-slate-300 border-t-blue-500 rounded-full animate-spin mx-auto mb-3" />
            <p className="text-sm text-slate-400">Yükleniyor...</p>
          </div>
        ) : filtered.length === 0 ? (
          <div className="p-6 text-center text-slate-400 text-sm">Sonuç bulunamadı</div>
        ) : (
          <>
            <ul>
              {visible.map((table) => (
                <li key={table.name}>
                  <button
                    onClick={() => onSelect(table.name)}
                    title={table.name}
                    className={`w-full text-left px-4 py-2 text-sm transition-colors truncate flex items-center gap-2 border-b border-slate-100 last:border-0 ${
                      selectedTable === table.name
                        ? "bg-blue-50 text-blue-700 font-medium border-l-2 border-l-blue-500"
                        : "text-slate-600 hover:bg-white hover:text-slate-900"
                    }`}
                  >
                    <svg
                      className={`w-3.5 h-3.5 shrink-0 ${selectedTable === table.name ? "text-blue-500" : "text-slate-300"}`}
                      fill="currentColor" viewBox="0 0 20 20"
                    >
                      <path d="M3 4a1 1 0 000 2h14a1 1 0 000-2H3zM3 8a1 1 0 000 2h14a1 1 0 000-2H3zM3 12a1 1 0 000 2h14a1 1 0 000-2H3z" />
                    </svg>
                    <span className="truncate">{table.name}</span>
                  </button>
                </li>
              ))}
            </ul>

            {/* Infinite scroll sentinel */}
            <div ref={sentinelRef} className="py-2 text-center">
              {hasMore && (
                <p className="text-[11px] text-slate-400">
                  {visibleCount.toLocaleString()} / {filtered.length.toLocaleString()} gösteriliyor
                </p>
              )}
            </div>
          </>
        )}
      </div>

      {/* Footer */}
      <div className="px-4 py-2 border-t border-slate-200 bg-white shrink-0">
        <p className="text-[11px] text-slate-400">
          {tables.length.toLocaleString()} tablo
          {search ? ` • ${filtered.length.toLocaleString()} eşleşme` : ""}
        </p>
      </div>
    </aside>
  );
}
