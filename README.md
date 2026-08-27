## Mert Türkoğlu

**AI/ML Engineer · MSc Computer Engineering** — I build AI systems that run on your own hardware and produce output reliable enough to ship.

Backend engineer by background (C# / .NET), now working on Retrieval-Augmented Generation, LLM integration, on-premise inference and vector search. Most of what I build answers the same question: how do you get useful, verifiable output out of a language model without a single byte leaving the network?

Currently doing an **MSc in Computer Engineering** (2026–).

### What I work on

- **RAG & vector search** — document chunking, embedding stores (Qdrant, PostgreSQL), semantic retrieval pipelines
- **On-prem inference** — Ollama, LM Studio, Gemma; sensitive data stays inside the network
- **Structured-output reliability** — strict JSON schemas, validation, a normalization layer that recovers malformed model output, and retries
- **LLM serving infrastructure** — OpenAI-compatible gateways, model aliasing, multi-key auth, streaming, embeddings endpoints

### Open source

| Contribution | What it was |
|---|---|
| [**dotnet/maui**](https://github.com/dotnet/maui) | BlazorWebView URL parsing fix. `Path.HasExtension()` was run against the whole URL, so a query parameter like `?weight=62.5` looked like a file extension and blocked force-reload; the fix checks only the path component. **Shipped in .NET 10.** |
| [**microsoft/windows-drivers-rs**](https://github.com/microsoft/windows-drivers-rs/pull/575) | `cargo wdk new` now respects default VCS behavior — removed a hardcoded `--vcs none`. Merged Nov 2025. |
| [**UI5/webcomponents**](https://github.com/UI5/webcomponents) | Theming fix for read-only TextArea focus and border. |

I also run [**BuzzSpire**](https://github.com/BuzzSpire) — an open-source organization, not a commercial company (I own the trademark; the org itself is a community project). Its main library is [**Nexar**](https://github.com/BuzzSpire/Nexar), an HTTP client for .NET: fluent request builder, typed responses, interceptors, exponential-backoff retries and auth helpers. 76+ tests, 100% pass, 95% coverage, MIT.

### Selected work

| Project | What it is | Stack |
|---|---|---|
| **Internal LLM Platform** | Fully on-premise RAG assistant answering questions over company documents. Qdrant + PostgreSQL embedding store, chunking and semantic retrieval, local Gemma inference, API key management, one-command Docker Compose deploy. | .NET 9 · Next.js 15 · Qdrant · Ollama |
| **ollama-middleware** | OpenAI-compatible gateway in front of local models — `/v1/chat/completions`, `/v1/completions`, `/v1/embeddings`, `/v1/models`, Bearer auth, streaming, sampling passthrough. Model aliasing keeps the underlying model identity out of every response. | Node.js · TypeScript |
| **Teams AI reporting pipeline** | Meeting transcripts → deterministic, schema-conformant JSON reports (summary, decisions, action items, risks). Multi-tenant isolation, on-prem inference. | Next.js · Ollama · SQLite |
| **On-prem assistant for OpenText SMAX** | Manifest V3 Chrome extension embedding a local LLM inside an ITSM interface. Zero-click ticket context capture, prompt-injection hardening across three isolated JS execution contexts. | TypeScript · React · CRXJS |
| [**neuralnetwork3d**](https://github.com/tw4/neuralnetwork3d) | Watch neural networks train in live 3D in the browser — zero dependencies. | Python · HTML |
| [**onmic.io**](https://onmic.io) | Self-hosted, always-on WebRTC voice + screen share over a peer-to-peer mesh — no media server. coturn TURN for clients behind NAT, Caddy for automatic TLS, single `docker compose up`. | TypeScript · React · Fastify |
| [**csharp-ile-programlama**](https://github.com/tw4/csharp-ile-programlama) | The 232 code listings from a C# / .NET 10 book I wrote (41 chapters, not yet published). Every listing is syntax-checked with Roslyn in the build pipeline. | C# |
| [**OCRmyPDF-Qt-GUI-Client**](https://github.com/tw4/OCRmyPDF-Qt-GUI-Client) | Multi-threaded Qt GUI for OCRmyPDF, 100+ languages. | Python · PyQt5 |

### Toolbox

- **AI/ML** — RAG, LLMs, embeddings, vector search, semantic retrieval, structured-output validation, on-prem inference, Ollama, Gemma, Qdrant, PyTorch
- **Languages** — Python, C#, TypeScript, JavaScript, Rust, C/C++, SQL
- **Backend** — .NET 8/9, ASP.NET Core, EF Core, Node.js, microservices, REST, YARP API gateway, JWT auth, Clean Architecture, DDD
- **Data & infra** — PostgreSQL, SQL Server, Qdrant, Redis, Elasticsearch, Docker, Docker Compose, GitHub Actions, Cloudflare Tunnel
- **Frontend** — Next.js, React, TypeScript, Tailwind CSS
- **Enterprise** — Siemens Teamcenter PLM (ITK, SOA, Active Workspace), SAP T4S, OpenText SMAX, Active Directory / LDAP, Microsoft Graph

### Day job

Backend and enterprise integration, on-site in İstanbul: secure integration services between Siemens Teamcenter PLM, SAP and ITSM systems — Teamcenter server extensions and custom handlers in C/C++ (ITK), SOA and REST services in C# / .NET, a YARP-based API gateway with JWT auth, AD/LDAP and Microsoft Graph user sync, PostgreSQL and SQL Server, Docker and CI/CD. **The AI work above is all personal.**

### Elsewhere

- Website — [mertturkoglu.com](https://www.mertturkoglu.com)
- LinkedIn — [in/18w](https://www.linkedin.com/in/18w)
