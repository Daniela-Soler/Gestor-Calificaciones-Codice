# Sistema de Gestión Instituto CODICE 🏫

Una aplicación de escritorio desarrollada en C# y .NET para la gestión integral de procesos académicos. El sistema permite administrar calificaciones, asistencias, estudiantes y cursos, utilizando una arquitectura robusta de 3 capas y una base de datos relacional en SQL Server. 

El diseño de la interfaz de usuario destaca por una estética clásica inspirada en los sistemas operativos Windows XP/Vista.

## 🚀 Características Principales
* **Gestión Académica (CRUD):** Administración completa de registros de Estudiantes, Cursos y Asignaturas.
* **Control de Asistencia:** Registro y actualización de asistencias mediante formularios dinámicos.
* **Gestor de Calificaciones:** Ingreso de notas con reglas de negocio estrictas, incluyendo validación automática del rango de notas entre 0 y 7.
* **Autenticación y Sesiones:** Sistema de inicio de sesión seguro con almacenamiento de estado de usuario activo.
* **Filtros Avanzados:** Consultas relacionales para obtener estudiantes matriculados por curso y asignatura.

## 🛠️ Stack Tecnológico
* **Lenguaje:** C#
* **Framework:** .NET (Windows Forms)
* **Base de Datos:** SQL Server 
* **Patrón de Arquitectura:** 3 Capas (Presentación, Negocio, Datos)

## 🏗️ Arquitectura del Proyecto
El código está estructurado para separar responsabilidades y asegurar la escalabilidad del software:
1. **Capa de Datos (`CD_`):** Gestiona la conexión a SQL Server y ejecuta operaciones en la base de datos mediante clases específicas para cada entidad.
2. **Capa de Negocio (`CN_`):** Aplica la lógica de negocio y valida la integridad de los datos antes de persistirlos en la base de datos.
3. **Capa de Presentación:** Interfaces gráficas interactivas desarrolladas en Windows Forms para facilitar la operación del usuario final.

## ⚙️ Prácticas de Ingeniería de Software
* Levantamiento de requerimientos funcionales y no funcionales.
* Diseño de arquitectura de software mediante Diagramas de Clases.
* Implementación de Pruebas Unitarias para asegurar la calidad del código.
