# Demostración del Sistema de Fidelidad de Clientes

## Instrucciones para Probar el Sistema

### 1. Compilar y Ejecutar
```bash
cd SupermarketLoyaltySystem
dotnet build
dotnet run
```

### 2. Login del Sistema
- **Usuario:** `admin`
- **Contraseña:** `password`

### 3. Funcionalidades a Probar

#### A. Registro de Clientes
1. Hacer clic en "Registrar Cliente"
2. Completar los siguientes datos de prueba:

**Cliente 1:**
- Nombre: Juan Pérez
- Teléfono: 555-0123
- Email: juan.perez@email.com
- Compra Inicial: $50.00
- Puntos Otorgados: 500

**Cliente 2:**
- Nombre: María González
- Teléfono: 555-0456
- Email: maria.gonzalez@email.com
- Compra Inicial: $75.00
- Puntos Otorgados: 750

**Cliente 3:**
- Nombre: Carlos Rodríguez
- Teléfono: 555-0789
- Email: carlos.rodriguez@email.com
- Compra Inicial: $100.00
- Puntos Otorgados: 1000

#### B. Canje de Puntos
1. Hacer clic en "Canjear Puntos"
2. Buscar cliente por nombre (ej: "Juan")
3. Seleccionar cliente de la lista
4. Ingresar cantidad de puntos a canjear (ej: 200)
5. Confirmar transacción

#### C. Visualización del Dashboard
- Observar las estadísticas actualizadas:
  - Total de Clientes
  - Total de Puntos Otorgados
  - Transacciones del Día
  - Puntos Canjeados Hoy

#### D. Lista de Clientes
- Ver todos los clientes registrados en la lista principal
- Usar "Actualizar" para refrescar los datos

### 4. Archivos Generados

Durante la ejecución, el sistema creará:
- `loyalty.db` - Base de datos SQLite con toda la información
- `error_log.txt` - Log de errores y eventos del sistema

### 5. Escenarios de Prueba

#### Escenario 1: Registro Completo
1. Registrar 3 clientes con diferentes montos de compra
2. Verificar que los puntos se calculen correctamente (10 puntos por dólar)
3. Confirmar que aparezcan en la lista principal

#### Escenario 2: Canje de Puntos
1. Buscar un cliente específico
2. Intentar canjear más puntos de los disponibles (debe mostrar error)
3. Canjear una cantidad válida de puntos
4. Verificar que los puntos se actualicen correctamente

#### Escenario 3: Validaciones
1. Intentar registrar cliente sin nombre (debe mostrar error)
2. Intentar registrar cliente sin teléfono (debe mostrar error)
3. Ingresar email con formato incorrecto (debe mostrar error)
4. Ingresar caracteres no numéricos en campos de puntos (debe filtrar)

### 6. Verificación de Funcionalidades

✅ **Sistema de Login**
- Autenticación con credenciales
- Manejo de credenciales incorrectas

✅ **Gestión de Clientes**
- Registro con validaciones
- Búsqueda por nombre
- Visualización de lista completa

✅ **Sistema de Puntos**
- Cálculo automático (10 puntos por dólar)
- Acumulación de puntos
- Canje con validaciones

✅ **Dashboard Administrativo**
- Estadísticas en tiempo real
- Contadores actualizados
- Información del día actual

✅ **Base de Datos**
- Creación automática de tablas
- Persistencia de datos
- Transacciones seguras

✅ **Manejo de Errores**
- Logging automático
- Mensajes de error amigables
- Validaciones de entrada

### 7. Datos de Ejemplo para Pruebas Rápidas

```
Cliente: Ana Martín
Teléfono: 555-1111
Email: ana.martin@email.com
Compra: $25.00 (250 puntos)

Cliente: Pedro Sánchez
Teléfono: 555-2222  
Email: pedro.sanchez@email.com
Compra: $80.00 (800 puntos)

Cliente: Laura Jiménez
Teléfono: 555-3333
Email: laura.jimenez@email.com
Compra: $120.00 (1200 puntos)
```

### 8. Resultados Esperados

Después de completar las pruebas:
- **Total Clientes:** 6
- **Total Puntos:** 4500 (suma de todos los puntos otorgados)
- **Transacciones del Día:** Número de operaciones realizadas
- **Puntos Canjeados:** Suma de puntos utilizados

### 9. Troubleshooting

**Si el sistema no inicia:**
- Verificar que .NET 8.0 esté instalado
- Comprobar permisos de escritura en el directorio

**Si hay errores de base de datos:**
- Eliminar `loyalty.db` y reiniciar la aplicación
- Verificar el archivo `error_log.txt` para detalles

**Si los formularios no responden:**
- Verificar que todos los campos obligatorios estén completos
- Revisar el log de errores

### 10. Características Destacadas

🎯 **Interfaz Moderna**
- Diseño limpio con colores corporativos
- Tipografía clara y legible
- Navegación intuitiva

🔒 **Seguridad**
- Sistema de login
- Validaciones de entrada
- Manejo seguro de excepciones

📊 **Reportes en Tiempo Real**
- Dashboard con estadísticas actualizadas
- Contadores automáticos
- Información del día actual

💾 **Persistencia de Datos**
- Base de datos SQLite integrada
- Backup automático de transacciones
- Historial completo de operaciones

Este sistema está listo para uso en producción con las siguientes mejoras recomendadas:
- Autenticación con base de datos
- Reportes en PDF
- Backup automático programado
- Integración con sistemas de punto de venta
