# 📨 Sistema de Gestión de Envíos

Aplicación de escritorio desarrollada en **C# (.NET Framework 4.7.2)** utilizando **Windows Forms**.  
El sistema sigue una **arquitectura en capas** (GUI, BLL, DAL, BE) y gestiona el flujo completo de envíos de una empresa logística (similar a *Andreani* o *Correo Argentino*).

---

## 🏗️ Arquitectura del Proyecto

- **GUI:** Formularios WinForms (interfaz de usuario)
- **BE (Business Entities):** Clases de entidades (POCO)
- **BLL (Business Logic Layer):** Lógica de negocio y validaciones
- **DAL (Data Access Layer):** Acceso a base de datos (SQL Server local)
- **Acceso:** Clase monolítica de conexión con métodos `Leer`, `Escribir` y `ObtenerDato`

---

## 🚀 Funcionalidad General

El sistema permite **registrar, administrar y seguir envíos** hasta su entrega.

### Roles de usuario

- **Administrador**
  - Registra y modifica envíos (recibidos de otros sistemas o archivos XML)
  - Asigna repartidores
  - Realiza ABM (Alta, Baja, Modificación) de usuarios

- **Cliente**
  - Puede registrarse y consultar sus envíos y su estado actual

- **Repartidor**
  - Visualiza los envíos asignados
  - Puede marcar los envíos como *Entregados*

> Todos los usuarios se pueden registrar e iniciar sesión.  
> Por defecto se registran como **Cliente**, y un Administrador puede asignarles el rol correspondiente.

---

## 🧱 Entidades (Capa BE)

### 🧍 `Usuario`
- `Id : int`
- `Email : string`
- `Password : string`
- `Nombre : string`
- `Activo : bool`

---

---

### 📦 `ItemPaquete`
- `Descripcion : string`
- `Peso : decimal`
- `Fragil : bool`
- `Costo : decimal`

---

### ✉️ `Envio`
- `Paquetes : List<ItemPaquete>`
- `CodigoSeguimiento : string`
- `Estado : EnumEstados`
- `FechaCreacion : DateTime`
- `FechaAsignacion : DateTime`
- `FechaDespacho : DateTime`
- `FechaEntrega : DateTime`
- `Destino : string`
- `Cliente : Cliente`
- `Repartidor : Repartidor`

---

### 🏷️ `EnumEstados`
```csharp
public enum EnumEstados
{
    Creado = 0,
    Asignado = 1,
    EnCamino = 2,
    Entregado = 3,
    Cancelado = 4
}
