**Idiomas:**  
[🇺🇸 English](README.md) | [🇬🇹 Español](README.es.md)

# Plantilla de Arquitectura Empresarial en .NET

Una base arquitectónica robusta y de nivel empresarial, impulsada por Arquitectura Limpia, con componentes .NET modulares, escalables y completamente testeables — diseñada por [Luis López](https://github.com/luislopez-dev).

Esta plantilla proporciona una estructura limpia y extensible que acelera el desarrollo de **sistemas corporativos internos y software empresarial crítico empresarial**.

**Si encuentras valiosa esta arquitectura, porfavor considera apoyarla con una estrella ⭐. Tu apoyo me motiva a seguir mejorándola e incorporando nuevas capacidades y funcionalidades de nivel empresarial.**

---

## Visión General de la Arquitectura

La solución está organizada en capas independientes y claramente definidas, diseñadas para reforzar la separación de responsabilidades, la testabilidad y la mantenibilidad a gran escala:

<img width="700" height="400" alt="enterprise-dotnet-architecture" src="https://github.com/user-attachments/assets/e106d323-4e53-4085-9be0-af0e9a09146c" />

### **Presentation**
Gestiona los endpoints de la API, modelos de request/response, controladores y preocupaciones transversales relacionadas con las solicitudes HTTP.

### **Application**
Contiene los casos de uso, reglas de negocio, lógica de aplicación y orquestación.

### **Business**
Lógica de dominio, entidades y comportamiento específico del negocio. Totalmente independiente de la infraestructura y la capa de presentación.

### **Infrastructure**
Implementa las integraciones externas: persistencia de datos, repositorios, servicios externos, mensajería, proveedores de autenticación, entre otros.

---

## Estructura Orientada a Pruebas

Cada capa incluye su propio proyecto de pruebas dedicado, garantizando aislamiento, estabilidad y confiabilidad a largo plazo:

- `Presentation.Tests`
- `Application.Tests`
- `Business.Tests`
- `Infrastructure.Tests`

Esta plantilla está diseñada para organizaciones que valoran la **calidad, reproducibilidad y mantenibilidad a largo plazo**.

---

## Listo para DevOps & Automatización

Esta plantilla incluye soporte integrado para flujos modernos de DevOps, permitiendo entornos consistentes, despliegues confiables e integración continua desde el primer día.

### **Docker & Contenerización**
- **Dockerfile** preconfigurado para la aplicación
- Configuración **docker-compose** para orquestar servicios
- Soporte integrado para **SQL Server** mediante contenedor para entornos locales e integración

Estas herramientas ofrecen un entorno reproducible y orientado a producción desde el inicio.

### **GitHub Actions — CI Pipeline**
Incluye un workflow optimizado que automatiza:

- Restauración de dependencias
- Construcción de la solución
- Ejecución de pruebas por capa

Garantizando calidad, confiabilidad e integridad arquitectónica en toda la solución.

---

## Usando la Plantilla con `dotnet new`

Esta arquitectura también está disponible como una **template package en NuGet**, permitiendo generar una solución enterprise completa con un solo comando.

### **Instalar la Plantilla**

```bash

dotnet new install Enterprise.Architecture.Template

dotnet new enterprise-architecture -n YourProjectName

```

---

## Principios Clave

- **Arquitectura Limpia**
- **Diseño SOLID**
- **Soporte para Desarrollo Orientado a Pruebas (TDD)**
- **Aislamiento por Capas**
- **Extensibilidad Plug-and-Play**
- **Estructura lista para soluciones empresariales de gran escala**

El código está estructurado para crecer junto con tu aplicación — no para limitarla.

---

## Ideal Para

- Empresas que están modernizando sistemas heredados
- Equipos que necesitan una base arquitectónica probada
- Desarrolladores que desean acelerar proyectos .NET de nivel empresarial

Esto es una **base**, no un producto completo.  
Está diseñada para equipos que necesitan un **punto de partida de alto nivel** para construir aplicaciones serias y escalables.

---

## Por Qué Existe Esta Plantilla

Las decisiones arquitectónicas incorrectas en las primeras etapas de un proyecto generan fricción, deuda técnica y limitaciones a largo plazo.

Esta plantilla existe para proporcionar:

- Una **arquitectura sólida y preparada para el futuro**
- Una **estructura modular y consistente**
- Un **entorno empresarial realista**
- Una **estrategia de pruebas robusta en todas las capas**

Úsala como base. Adáptala. Extiéndela.

---

## Soporte Empresarial & Consultoría

Si tu organización necesita:

- Guía arquitectónica  
- Integraciones personalizadas  
- Diseño backend escalable  
- Migración hacia arquitecturas cloud-native  
- Optimización de rendimiento  
- Soporte empresarial completo  

Puedes contactarme en:

**luis.dev.master@gmail.com**

---

## Video Demostrativo

[![Architecture Template Demo](https://img.youtube.com/vi/mJzvkAc4cLI/0.jpg)](https://www.youtube.com/watch?v=mJzvkAc4cLI)

---

## Creado y mantenido por [Luis López](https://github.com/luislopez-dev)

---

## Construye bases sólidas. Entrega sistemas escalables.
