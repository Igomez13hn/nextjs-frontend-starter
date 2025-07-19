# Sistema de Fidelidad de Clientes para Supermercado

## Descripción
Sistema desarrollado en Visual Basic .NET para gestionar un programa de fidelidad de clientes en supermercados. Permite registrar clientes, acumular puntos por compras y gestionar canjes de puntos.

## Características Principales

### 🔐 Autenticación
- Login seguro para gerentes/administradores
- Credenciales por defecto: `admin` / `password`

### 👥 Gestión de Clientes
- Registro de nuevos clientes con información completa
- Búsqueda de clientes por nombre
- Visualización de lista completa de clientes registrados

### 🎯 Sistema de Puntos
- **Acumulación**: 1 punto por cada dólar gastado
- **Canje**: Los clientes pueden canjear sus puntos acumulados
- **Historial**: Registro completo de todas las transacciones

### 📊 Dashboard Administrativo
- **Total de Clientes**: Número total de clientes registrados
- **Total de Puntos**: Suma de todos los puntos otorgados
- **Transacciones del Día**: Actividad diaria del sistema
- **Puntos Canjeados Hoy**: Puntos utilizados en el día actual

## Tecnologías Utilizadas

- **Lenguaje**: Visual Basic .NET
- **Framework**: .NET 8.0
- **UI**: Windows Forms
- **Base de Datos**: SQLite
- **Arquitectura**: Aplicación de escritorio con patrón de capas

## Estructura del Proyecto

```
SupermarketLoyaltySystem/
├── ApplicationEvents.vb          # Eventos de aplicación y punto de entrada
├── MainForm.vb                   # Formulario principal con dashboard
├── LoginForm.vb                  # Formulario de autenticación
├── CustomerRegistrationForm.vb   # Registro de nuevos clientes
├── CustomerRedemptionForm.vb     # Canje de puntos
├── Customer.vb                   # Modelo de datos del cliente
├── DataAccess.vb                 # Capa de acceso a datos
├── Logger.vb                     # Sistema de logging
├── App.config                    # Configuración de la aplicación
└── SupermarketLoyaltySystem.vbproj # Archivo de proyecto
```

## Instalación y Configuración

### Prerrequisitos
- .NET 8.0 Runtime o superior
- Windows 10/11 (recomendado)

### Pasos de Instalación
1. Clonar o descargar el proyecto
2. Abrir terminal en la carpeta del proyecto
3. Ejecutar: `dotnet restore`
4. Compilar: `dotnet build`
5. Ejecutar: `dotnet run`

## Uso del Sistema

### 1. Inicio de Sesión
- Usuario: `admin`
- Contraseña: `password`

### 2. Registro de Cliente
1. Hacer clic en "Registrar Cliente"
2. Completar información del cliente:
   - Nombre completo (obligatorio)
   - Teléfono (obligatorio)
   - Email (opcional)
   - Compra inicial (opcional)
3. El sistema calculará automáticamente los puntos iniciales
4. Confirmar registro

### 3. Canje de Puntos
1. Hacer clic en "Canjear Puntos"
2. Buscar cliente por nombre
3. Seleccionar cliente de la lista
4. Ingresar cantidad de puntos a canjear
5. Confirmar transacción

### 4. Consulta de Información
- **Dashboard**: Estadísticas en tiempo real
- **Lista de Clientes**: Ver todos los clientes registrados
- **Actualizar**: Refrescar datos del dashboard

## Base de Datos

El sistema utiliza SQLite con las siguientes tablas:

### Tabla `Customers`
- `CustomerID` (INTEGER, PRIMARY KEY)
- `Name` (TEXT, NOT NULL)
- `ContactNumber` (TEXT)
- `Email` (TEXT)
- `Points` (INTEGER, DEFAULT 0)
- `RegistrationDate` (DATETIME)

### Tabla `Transactions`
- `TransactionID` (INTEGER, PRIMARY KEY)
- `CustomerID` (INTEGER, FOREIGN KEY)
- `TransactionType` (TEXT) - 'EARN' o 'REDEEM'
- `Points` (INTEGER)
- `Description` (TEXT)
- `TransactionDate` (DATETIME)

## Configuración

### Archivo App.config
```xml
<connectionStrings>
  <add name="LoyaltyDB" connectionString="Data Source=loyalty.db;Version=3;" />
<appSettings>
  <add key="CompanyName" value="Supermercado El Ahorro" />
  <add key="PointsPerDollar" value="1" />
  <add key="MinimumRedemption" value="100" />
</appSettings>
```

## Logging

El sistema registra automáticamente:
- Errores y excepciones en `error_log.txt`
- Eventos importantes (login, registros, canjes)
- Información de depuración

## Características de Seguridad

- Validación de entrada de datos
- Manejo de excepciones robusto
- Logging de actividades
- Transacciones de base de datos seguras
- Validación de puntos antes del canje

## Personalización

### Modificar Puntos por Dólar
Cambiar el valor en `App.config`:
```xml
<add key="PointsPerDollar" value="1" />
```
O modificar el método `GetConversionRate()` en `CustomerRegistrationForm.vb` para usar diferentes lógicas de cálculo.

### Cambiar Credenciales de Login
Modificar en `LoginForm.vb`:
```vb
If txtUsername.Text.Trim().ToLower() = "admin" AndAlso txtPassword.Text = "password" Then
```

## Solución de Problemas

### Error de Base de Datos
- Verificar que el archivo `loyalty.db` tenga permisos de escritura
- Revisar la cadena de conexión en `App.config`

### Error de Compilación
- Verificar que .NET 8.0 esté instalado
- Ejecutar `dotnet restore` para restaurar paquetes

### Problemas de Interfaz
- Verificar que Windows Forms esté habilitado
- Comprobar resolución de pantalla

## Futuras Mejoras

- [ ] Autenticación con base de datos
- [ ] Reportes avanzados en PDF
- [ ] Integración con sistemas de punto de venta
- [ ] Notificaciones por email
- [ ] Aplicación móvil complementaria
- [ ] Backup automático de datos
- [ ] Múltiples niveles de usuario

## Soporte

Para soporte técnico o consultas:
- Revisar logs en `error_log.txt`
- Verificar configuración en `App.config`
- Consultar documentación del código

## Licencia

Este proyecto es de uso educativo y demostrativo.

---

**Desarrollado con Visual Basic .NET para gestión de fidelidad de clientes en supermercados**
