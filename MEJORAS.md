# 💡 IDEAS FUTURAS - Sistema de Gestión de Envíos

Este documento recopila posibles mejoras y ampliaciones para el sistema de gestión de envíos.  
Las ideas están agrupadas por categoría y pensadas para implementarse en futuras versiones del proyecto.

---

## 🧮 Cálculo de Costos Avanzado

- Agregar el **cálculo de costo según distancia** o zona geográfica.
  - Crear una **tabla de direcciones o regiones** donde se definan reglas como:
    - Envíos dentro de la misma provincia → costo base.
    - Envíos a provincias limítrofes → costo base + $X adicional.
    - Envíos al resto del país → costo base + $Y adicional.
  - Implementar lógica en la BLL para combinar:
    - **Costo fijo**
    - **Costo por peso o volumen**
    - **Costo por distancia o región**

- Permitir definir **tarifas personalizadas por cliente** o por tipo de envío.

---

## 🏢 Gestión de Sucursales

- Agregar una tabla `Sucursal` para identificar el **origen físico** del envío.
- Cada envío debería asociarse a una sucursal de origen:
  - `IdSucursalOrigen`
  - `Direccion`, `Provincia`, `Localidad`, `CodigoPostal`
- Un administrador podría gestionar las sucursales (ABM).

---

## 🚛 Gestión de Vehículos y Flota

- Asignar **vehículos** a los repartidores.
- Crear una nueva entidad `Vehiculo`:
  - `Patente`, `Tipo` (Moto, Auto, Camión)
  - `CapacidadMaxKg`
  - `Estado` (Activo/Inactivo)
- Relacionar `Vehiculo` ↔ `Repartidor`
- Permitir que el sistema sugiera un repartidor según disponibilidad y tipo de vehículo.

---

## 📦 Integración con otros sistemas

- **Importar envíos desde archivos XML** recibidos de otro sistema.
  - Lectura automática desde una carpeta (`/Importados`).
  - Validación de estructura XML (XSD).
  - Creación de los envíos de forma masiva en la base de datos.

    
---

## 💾 Otras mejoras posibles

- Log de auditoría (registro de operaciones de usuarios: altas, bajas, cambios).
- Validación y normalización de direcciones.
- Multilenguaje (ESP / ENG).
- Notificaciones por correo o SMS ante cambios de estado.
- Mejorar la interfaz gráfica (UI/UX) con estilos modernos (ej. Material Design para WinForms).

---

## 🧩 Prototipos futuros de entidades

### Entidad `Sucursal`
```csharp
public class Sucursal
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Localidad { get; set; }
    public string Provincia { get; set; }
    public string CodigoPostal { get; set; }
}
