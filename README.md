# EFinal - API de Vehículos

API REST en ASP.NET Core 8 + Entity Framework Core (SQL Server) para administrar la tabla `tbVehiculo` de la base de datos `EFinal`.

## Tabla `tbVehiculo`

| Columna | Tipo | Notas |
|---------|------|-------|
| id | int | Llave primaria, autoincrementable (IDENTITY 1,1) |
| placa | nvarchar(max) | |
| marca | nvarchar(max) | |
| modelo | nvarchar(max) | |
| anio | int | Año del vehículo |
| color | nvarchar(max) | |
| estado | bit | `true` = Activo, `false` = Inactivo |

## Endpoints

| Método | Ruta | Descripción |
|--------|------|-------------|
| GET | `/api/vehiculos` | Obtener el listado de todos los vehículos |
| POST | `/api/vehiculos` | Crear un nuevo registro |
| PATCH | `/api/vehiculos/{id}` | Actualizar un registro existente |
| DELETE | `/api/vehiculos/{id}` | Eliminar un registro |

Ejemplo de cuerpo (POST / PATCH):

```json
{
  "placa": "P123ABC",
  "marca": "Toyota",
  "modelo": "Corolla",
  "anio": 2020,
  "color": "Blanco",
  "estado": true
}
```

## Cómo ejecutar

1. Revisar la cadena de conexión `ConexionSql` en `EFinal/appsettings.json` (por defecto: `Server=localhost;Database=EFinal;Trusted_Connection=True;TrustServerCertificate=True`).
2. Crear la base de datos con las migraciones (`v1` crea la tabla y `v2` agrega `estado`):
   - Consola del Administrador de paquetes: `Update-Database`
   - o CLI: `dotnet ef database update --project EFinal`
   - (Alternativa: ejecutar `database.sql` en SQL Server Management Studio.)
3. Ejecutar el proyecto y abrir Swagger en `http://localhost:5237/swagger`.

## Estructura

```
EFinal/
├── Controllers/VehiculoController.cs
├── Data/AplicationDbContext.cs
├── Mapper/VehiculoMapper.cs
├── Migrations/
├── Modelos/Vehiculo.cs
├── Modelos/DTOS/VehiculoDTO.cs, CrearVehiculoDTO.cs
├── Repositorio/VehiculoRepositorio.cs
└── Repositorio/IRepositorio/IVehiculoRepositorio.cs
```
