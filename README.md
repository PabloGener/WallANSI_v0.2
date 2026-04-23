# 🎨 WallANSI v0.2

**WallANSI** es un editor y generador de gráficos ANSI para Windows Forms (.NET). Permite crear arte ASCII/ANSI con colores, aplicar patrones repetitivos y guardar el resultado en formatos `.ans` (clásico de MS-DOS) y `.rtf`.

---

## ✨ Características

- ✅ **Renderizado de patrones**: Repite una secuencia de caracteres coloreados en un área de 24x80 (estándar ANSI).
- ✅ **Inyección de texto**: Carga archivos `.txt` y los posiciona en la columna 15 (centrado visual).
- ✅ **Paleta de colores**: 15 colores estándar (normales + brillantes) aplicables a la selección actual.
- ✅ **Drag & Drop**: Arrastrá archivos `.txt` directamente al formulario.
- ✅ **Guardado múltiple**: Exportá a `.ans` (codificación OEM 437) o `.rtf`.
- ✅ **Bóveda (Vault)**: Área auxiliar para almacenar texto con formato.
- ✅ **Decorador de líneas**: Ajusta líneas seleccionadas a 50 caracteres y las centra.
- ✅ **Tooltips**: Ayudas visuales en los botones principales.

---

## 🖼️ Capturas de pantalla

*(Agregá acá imágenes de tu programa en acción)*

> 💡 *Sugerencia: Tomá capturas de la interfaz principal, el drag & drop, y el resultado final en un visor ANSI.*

---

## 🚀 Cómo usarlo

### 1. **Secuencia (patrón)**
- Escribí o pegá una secuencia de caracteres en `rtfSecuencia`.
- Seleccioná colores desde la paleta para aplicarles formato.
- La secuencia se repetirá cíclicamente para llenar el área de 80 columnas.

### 2. **Cargar texto**
- Arrastrá un archivo `.txt` al formulario.
- El texto se cargará automáticamente en `rtfTexto` (múltiples líneas).
- Las líneas se posicionarán comenzando en la columna 15.

### 3. **Aplicar formato**
- Seleccioná texto en `rtfSecuencia` o `rtfTexto`.
- Hacé clic en un botón de color para cambiar el color del texto seleccionado.

### 4. **Decorar líneas**
- Seleccioná varias líneas en `rtfTexto`.
- Hacé clic en **Decorar** para:
  - Ajustar cada línea a 50 caracteres (rellena con espacios).
  - Aplicar color blanco.
  - Centrar el bloque en el área de 80 columnas.

### 5. **Guardar**
- Usá el botón **Guardar ANSI**.
- Elegí entre formato `.ans` (ANSI puro, compatible con visores clásicos) o `.rtf`.
- Si elegís `.rtf`, se guarda directamente con el formato de Windows.

### 6. **Bóveda (Vault)**
- Hacé doble clic en `rtfSecuencia` para mostrar la bóveda.
- Guardá fragmentos de texto con formato para reutilizarlos luego.
- Usá **Pegar** para insertar el contenido seleccionado en `rtfSecuencia`.

---

## ⌨️ Atajos y funcionalidades clave

| Acción | Cómo hacerlo |
|--------|---------------|
| Cargar archivo `.txt` | Arrastrarlo al formulario |
| Mostrar tabla ASCII | Botón **ASCII** |
| Mostrar/ocultar colores | Botón **Colores** |
| Decorar líneas seleccionadas | Botón **Decorar** |
| Guardar proyecto | Botón **Guardar ANSI** |
| Abrir bóveda | Doble clic en `rtfSecuencia` |
| Cerrar bóveda | Botón **X** en la bóveda |

---

## 📁 Estructura del proyecto

**WallANSI** es un editor y generador de gráficos ANSI para Windows Forms (.NET). Permite crear arte ASCII/ANSI con colores, aplicar patrones repetitivos y guardar el resultado en formatos `.ans` (clásico de MS-DOS) y `.rtf`.
WallANSI_v0.2/

├── frmMain.cs # Lógica principal

├── frmMain.Designer.cs # Diseño de interfaz

├── Program.cs # Punto de entrada

├── boveda.rtf # Archivo autogenerado de la bóveda

└── README.md # Este archivo



## 🛠️ Tecnologías usadas

- **Lenguaje**: C# (.NET Framework / .NET Core Windows Forms)
- **IDE**: Visual Studio 2022
- **Controles principales**: `RichTextBox`, `GroupBox`, `Button`, `SaveFileDialog`
- **Codificación ANSI**: OEM 437 (para compatibilidad con MS-DOS)
- **Fuente recomendada**: Courier New (monoespaciada)

---

## 📄 Licencia

Este proyecto está bajo la licencia **Creative Commons Attribution-ShareAlike 4.0 International (CC BY-SA 4.0)**.

Sos libre de:
- **Compartir** — copiar y redistribuir el material en cualquier medio o formato.
- **Adaptar** — remezclar, transformar y construir a partir del material para cualquier propósito.

Bajo los siguientes términos:
- **Atribución** — Debés dar crédito apropiado, proporcionar un enlace a la licencia.
- **CompartirIgual** — Si remezclás, transformás o creás a partir del material, debés distribuir tus contribuciones bajo la misma licencia.

[Leer la licencia completa](https://creativecommons.org/licenses/by-sa/4.0/)

---

## 🙌 Agradecimientos

- A la comunidad de arte ASCII/ANSI por mantener viva esta forma de expresión.
- A Microsoft por Windows Forms.
- A los usuarios de FANSIN (el proyecto anterior) por el feedback.

---

## 📬 Contacto / Contribuciones

Si querés reportar un bug o sugerir una mejora, abrí un **Issue** en GitHub.  
Las contribuciones son bienvenidas bajo los términos de la licencia CC BY-SA 4.0.

---

**Hecho con ❤️ y C#. ¡Que viva el arte ANSI!**
