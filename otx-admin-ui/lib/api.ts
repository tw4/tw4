export type TableInfo = { name: string };

export type ColumnInfo = { name: string; type: string };

export type TableData = {
  columns: ColumnInfo[];
  rows: Record<string, unknown>[];
};

export async function fetchTables(baseUrl: string, filter?: string): Promise<TableInfo[]> {
  const url = filter
    ? `${baseUrl}/api/admin/tables?filter=${encodeURIComponent(filter)}`
    : `${baseUrl}/api/admin/tables`;
  const res = await fetch(url, { cache: 'no-store' });
  if (!res.ok) throw new Error(`API bağlantısı başarısız (${res.status}): ${baseUrl}`);
  return res.json();
}

export function getExportUrl(baseUrl: string, tableName: string, filter?: string): string {
  const params = new URLSearchParams();
  if (filter) params.set('filter', filter);
  const qs = params.size ? `?${params}` : '';
  return `${baseUrl}/api/admin/tables/${encodeURIComponent(tableName)}/export${qs}`;
}

export async function fetchTableData(
  baseUrl: string,
  tableName: string,
  page: number,
  pageSize: number,
  filter?: string
): Promise<TableData> {
  const params = new URLSearchParams({ page: String(page), pageSize: String(pageSize) });
  if (filter) params.set('filter', filter);
  const url = `${baseUrl}/api/admin/tables/${tableName}?${params}`;
  const res = await fetch(url, { cache: 'no-store' });
  if (!res.ok) {
    let detail = `Tablo verisi alınamadı (${res.status}): ${tableName}`;
    try {
      const body = await res.json();
      if (body?.error) detail = body.error;
    } catch { /* body parse edilemedi, genel mesaj kullan */ }
    throw new Error(detail);
  }
  return res.json();
}
