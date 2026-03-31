# Contexto:

# **Actividad Introducción**

Las herramientas de IA generativa como Microsoft Copilot son potentes asistentes para escribir código que generan código basado en tus instrucciones.

En esta actividad, utilizarás Copilot para escribir y mejorar código API para una API de gestión de usuarios. Este proyecto te permitirá practicar escribiendo código tú mismo y utilizando Copilot como ayuda. Utilizarás Copilot para generar código y luego para mejorarlo y probarlo.

### **Esta es la primera de tres actividades en las que desarrollarás y codificarás un proyecto de API back-end. El resultado final será un proyecto de API en funcionamiento que podrás utilizar para demostrar tus conocimientos de desarrollo de back-end.**

# **Instrucciones de la actividad**

## **Paso 1: Revisar el escenario**

Para empezar, revisa el siguiente escenario para entender la intención de este proyecto API.

**TechHive** Solutions te ha contratado para desarrollar una **API de gestión de usuarios** para sus herramientas internas. Los departamentos de RR.HH. y TI necesitan una API que les permita crear, actualizar, recuperar y eliminar registros de usuarios de forma eficiente. Tu tarea es construir la funcionalidad central de la API, utilizando **Microsoft Copilot** para andamiar, mejorar y probar el código.

## **Paso 2: Configurar el proyecto**

A continuación, comience a configurar su proyecto.

* Cree un nuevo proyecto de API web ASP.NET Core llamado **UserManagementAPI**.  
* Utilice Microsoft Copilot para organizar la configuración del proyecto, incluida la adición de código repetitivo a **Program.cs**.

## **Paso 3: Generar puntos finales de API**

A continuación, utilice Copilot para ayudarle a generar puntos finales de API.

* Utilice Copilot para generar puntos finales CRUD para la gestión de usuarios:  
  * **GET**: Recuperar una lista de usuarios o un usuario específico por ID.  
  * **POST**: Añadir un nuevo usuario.  
  * **PUT**: Actualizar los datos de un usuario existente.  
  * **DELETE**: Eliminar un usuario por ID.

## **Paso 4: Probar la funcionalidad de la API**

Por último, para completar esta fase del proyecto, prueba la API.

* Utilice Postman o una herramienta similar para probar todos los puntos finales CRUD.  
* Documente las formas específicas en que **Microsoft Copilot** ayudó a mejorar el código y la funcionalidad de la API.

## **Paso 5: Guarde su trabajo**

Al final de este ejercicio, debería tener una API de gestión de usuarios funcional con operaciones CRUD sólidas y documentación sobre cómo Copilot contribuyó a la generación y mejora del código. Cuando haya terminado, guarde su trabajo. Utilizará este código en actividades posteriores.

# **Introducción a la actividad**

Las herramientas de IA generativa como Microsoft Copilot pueden agilizar el proceso de depuración y mejorar el resultado final del código.

En esta actividad, utilizarás Copilot para depurar el código que has empezado para tu proyecto API. Este proyecto le permitirá practicar la revisión de código, la depuración y la implementación de correcciones. Utilizarás Copilot para descubrir problemas y sugerir cambios para mejorar tu código.

**Esta es la segunda de tres actividades en las que desarrollará y codificará un proyecto de API back-end. El resultado final será un proyecto de API en funcionamiento que podrá utilizar para demostrar sus conocimientos de desarrollo back-end.**

Antes de comenzar esta actividad, asegúrese de haber completado la primera actividad de este módulo, Escribir y mejorar código API con Copilot \[LINK\].

# **Instrucciones de la actividad**

## **Paso 1: Revisar el escenario**

Para comenzar, revise el siguiente escenario:

Después de desplegar la versión inicial de **la API de gestión de usuarios**, **TechHive Solutions** informó de varios errores. Por ejemplo:

* Se añadían usuarios sin la validación adecuada.  
* Se producían errores al recuperar usuarios inexistentes.  
* La API se bloqueaba ocasionalmente debido a excepciones no controladas.

Su tarea consiste en depurar la API utilizando **Microsoft Copilot**, asegurándose de que funciona de forma fiable y cumple los requisitos de la empresa.

## **Paso 2: Identificar errores**

A continuación, empiece a buscar problemas en el código que ha creado anteriormente.

* Utilice Copilot para analizar el código base existente e identificar los problemas:  
  * Falta de validación de los campos de entrada del usuario (por ejemplo, nombres vacíos o correos electrónicos no válidos).  
  * Falta de gestión de errores en búsquedas fallidas en bases de datos.  
  * Problemas de rendimiento en el punto final GET /users.

## **Paso 3: Corregir errores con Copilot**

A continuación, utilice Copilot para solucionar los problemas que haya identificado.

* Utilice Copilot para:  
  * Añadir validación para garantizar que solo se procesan datos de usuario válidos.  
  * Implementar bloques try-catch para gestionar las excepciones no gestionadas.  
  * Optimizar las consultas o la lógica para mejorar el rendimiento.

## **Paso 4: Probar y validar las correcciones**

Por último, pruebe el código depurado para completar esta fase del proyecto.

* Pruebe de nuevo los puntos finales de la API, centrándose en los casos extremos (por ejemplo, entradas no válidas, ID inexistentes).  
* Documente cómo las sugerencias de Copilot han ayudado a identificar y resolver los problemas.

## **Paso 5: Guarde su trabajo**

Al final de este ejercicio, debería tener una API de gestión de usuarios depurada y optimizada y un resumen de los errores solucionados y de cómo Copilot agilizó el proceso de depuración. Cuando haya terminado, guarde su trabajo. Utilizará este código en actividades posteriores.

# **Introducción a la actividad**

Las herramientas de IA generativa como Microsoft Copilot pueden ayudarte a implementar y gestionar middleware en tus proyectos de back-end.

En esta actividad, utilizarás Copilot para crear middleware para el registro, la autenticación y la gestión de errores, así como para configurar la canalización de middleware. Este proyecto le dará práctica trabajando con middleware, desde la implementación hasta la gestión. Copilot puede ayudarte en cada paso de este proceso.

Esta es la última de tres actividades en las que desarrollarás y codificarás un proyecto de API de back-end. El resultado final será un proyecto de API en funcionamiento que podrá utilizar para demostrar sus conocimientos de desarrollo back-end.

Antes de comenzar esta actividad, asegúrese de haber completado las dos actividades anteriores de este módulo, [Escribir y mejorar código API con Copilot](https://www.coursera.org/learn/back-end-development-with-dotnet/assignment-submission/LJCC1/activity-writing-and-enhancing-api-code-with-copilot) y [Depurar código API con Copilot](https://www.coursera.org/learn/back-end-development-with-dotnet/assignment-submission/JLFJp/activity-debugging-api-code-with-copilot)

# **Instrucciones de la actividad**

## **Paso 1: Revise el escenario**

Para comenzar, revise el siguiente escenario:

Para cumplir con las políticas corporativas, **TechHive Solutions** requiere que el middleware en la **API de Gestión de Usuarios**:

* Registre todas las solicitudes entrantes y respuestas salientes con fines de auditoría.  
* Aplique una gestión de errores estandarizada en todos los puntos finales.  
* Proteger los puntos finales de la API mediante autenticación basada en token.

Su tarea consiste en implementar estos componentes de middleware mediante **Microsoft Copilot** y configurar la canalización de middleware para obtener un rendimiento óptimo.

## **Paso 2: Implementar middleware de registro**

A continuación, comience a implementar middleware en el proyecto en el que ha trabajado en las actividades anteriores.

* Utiliza Copilot para escribir middleware que registre  
  * Método HTTP (por ejemplo, GET, POST).  
  * Ruta de solicitud.  
  * Código de estado de la respuesta.  
* Ejemplo de solicitud de Copilot:*"Generar middleware para registrar solicitudes y respuestas HTTP en ASP.NET Core"*

## **Paso 3: Implementar middleware de gestión de errores**

A continuación, cree la siguiente pieza de middleware.

* Utilice Copilot para crear middleware que:  
  * Capture las excepciones no gestionadas.  
  * Devuelva respuestas de error coherentes en formato JSON (por ejemplo, { **"error": "Internal server error." }**).

## **Paso 4: Implementar middleware de autenticación**

A continuación, crea otro middleware.

* Utiliza Copilot para escribir un middleware que:  
  * Valide los tokens de las solicitudes entrantes.  
  * Permita el acceso sólo a usuarios con tokens válidos.  
  * Devuelve una respuesta **401 Unauthorized** para los tokens no válidos.

## **Paso 5: Configurar el middleware**

Con su middleware en su lugar, asegúrese de que el middleware está configurado correctamente.

* Utilice Copilot para asegurarse de que el middleware está configurado en el orden correcto:  
  * Primero el middleware de gestión de errores.  
  * A continuación, el middleware de autenticación.  
  * Por último, el middleware de registro.

## **Paso 6: Probar la funcionalidad del middleware**

Por último, prueba el código para completar esta fase del proyecto.

* Prueba el middleware enviando varias peticiones (por ejemplo, tokens válidos/no válidos, activación de excepciones).  
* Valide que los registros son precisos y que los errores se gestionan de forma coherente.

## **Paso 7: Guarde su trabajo**

Al final de este ejercicio, usted debe tener middleware para el registro, gestión de errores, y la autenticación integrada en la API de gestión de usuarios y una tubería de middleware optimizado para el rendimiento y la seguridad. Una vez completado, guarda tu trabajo. Enviarás este proyecto de código para su revisión.

