<div align="center">

# Randevu Sistemi

Basit bir randevu kayıt **REST API**'si (.NET 8) ve bu API'ye bağlanacak bir
**Angular 21** istemci projesi.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![Angular](https://img.shields.io/badge/Angular-21-DD0031?logo=angular&logoColor=white)
![EF Core](https://img.shields.io/badge/EF%20Core-SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)

</div>

---

## 🎯 Proje Hakkında

Ad-soyad, tarih ve açıklama bilgisiyle randevu oluşturma, listeleme, güncelleme ve
silme işlemlerini sağlayan bir CRUD API. ASP.NET Core Web API + Entity Framework Core
ile geliştirilmiş, Angular tarafından CORS üzerinden çağrılacak şekilde yapılandırılmıştır.

## 📁 Proje Yapısı

```
RandevuSistemi/
├── Randevu_Sistemi_Back/        # .NET 8 Web API
│   └── Randevu_Sistemi/
│       ├── Controllers/
│       │   └── RandevuController.cs   # GET / POST / PUT / DELETE
│       ├── Models/
│       │   └── Randevu.cs             # Id, AdSoyad, Tarih, Aciklama
│       ├── Data/
│       │   └── AppDbContext.cs
│       ├── Migrations/
│       └── Program.cs
└── randevu-ui/                  # Angular 21 (SSR) istemci iskeleti
```

> **Not:** `randevu-ui` şu an Angular CLI'ın ürettiği başlangıç iskeletinde — randevu
> ekranları henüz bu projeye bağlanmadı. Asıl çalışan kısım backend API'sidir.

## 🔌 API Uç Noktaları

| Metod | Uç Nokta | Açıklama |
|---|---|---|
| GET | `/api/randevu` | Tüm randevuları listeler |
| POST | `/api/randevu` | Yeni randevu oluşturur |
| PUT | `/api/randevu/{id}` | Var olan randevuyu günceller |
| DELETE | `/api/randevu/{id}` | Randevuyu siler |

## 🛠️ Teknoloji Yığını

| Katman | Teknoloji |
|---|---|
| Backend | .NET 8, ASP.NET Core Web API, Entity Framework Core |
| Veritabanı | SQL Server (LocalDB) |
| API Dokümantasyonu | Swagger / OpenAPI |
| Frontend | Angular 21 (Server-Side Rendering iskeleti) |

## 🚀 Kurulum ve Çalıştırma

### Backend

```bash
cd Randevu_Sistemi_Back/Randevu_Sistemi
dotnet ef database update   # veritabanını oluştur
dotnet run
```

Development modunda Swagger arayüzüne API kökünden erişilebilir.

### Frontend

```bash
cd randevu-ui
npm install
npm start
```

Angular geliştirme sunucusu `http://localhost:4200` adresinde çalışır.

---

<div align="center">

*.NET 8 · Angular 21*

</div>
