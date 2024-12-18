﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto2.Models;
using System.ComponentModel.DataAnnotations;

namespace TestClientes
{
    [TestClass] 
    public sealed class Test1
    {
        // Prueba que un cliente válido pase la validación.
        [TestMethod]
        public void TestCliente_ClienteValido_DeberiaPasarLaValidacion()
        {
            // Arrange: 
            var cliente = new Cliente
            {
                Nombre = "Juan", // Nombre válido
                Correo = "juan@example.com", // Correo válido
                Tipo = "Cliente", // Tipo válido
                Contraseña = "1234" // Contraseña válida
            };

            // Act: 
            var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
            var esValido = Validator.TryValidateObject(cliente, new ValidationContext(cliente), resultadosValidacion, true);

            // Assert: Verificamos que el cliente sea válido (sin errores).
            Assert.IsTrue(esValido); // Esperamos que sea válido
        }

        // Prueba que un cliente con datos inválidos falle en la validación.
        [TestMethod]
        public void TestCliente_ClienteInvalido_DeberiaFallarLaValidacion()
        {
            // Arrange: Preparamos el cliente con datos inválidos (supera las longitudes máximas).
            var cliente = new Cliente
            {
                Nombre = "JuanJuanJuanJuanJuanJuan", // Nombre demasiado largo (más de 20 caracteres)
                Correo = "juan@example.com", // Correo válido
                Tipo = "Cliente", // Tipo válido
                Contraseña = "12345678901" // Contraseña demasiado larga (más de 10 caracteres)
            };

            // Act: Realizamos la validación.
            var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
            var esValido = Validator.TryValidateObject(cliente, new ValidationContext(cliente), resultadosValidacion, true);

            // Assert: Verificamos que la validación falle debido a los errores en los campos.
            Assert.IsFalse(esValido); // Esperamos que sea inválido
            Assert.AreEqual(2, resultadosValidacion.Count); // Esperamos 2 errores (por el nombre y la contraseña)
        }

        // Prueba que un cliente con campos requeridos vacíos falle en la validación.
        [TestMethod]
        public void TestCliente_FaltanCamposRequeridos_DeberiaFallarLaValidacion()
        {
            // Arrange: Preparamos el cliente con campos requeridos vacíos.
            var cliente = new Cliente
            {
                Nombre = null, 
                Correo = null, 
                Tipo = "Cliente", // Tipo válido
                Contraseña = "1234" // Contraseña válida
            };

            // Act: Realizamos la validación.
            var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
            var esValido = Validator.TryValidateObject(cliente, new ValidationContext(cliente), resultadosValidacion, true);

            // Assert: Verificamos que la validación falle debido a los campos faltantes.
            Assert.IsFalse(esValido); // Esperamos que sea inválido
            Assert.AreEqual(2, resultadosValidacion.Count); // Esperamos 2 errores (por el nombre y el correo)
        }

        [TestClass] 
        public sealed class TestEntrenador
        {
            // Prueba que un entrenador válido pase la validación.
            [TestMethod]
            public void TestEntrenador_EntrenadorValido_DeberiaPasarLaValidacion()
            {
                // Arrange: Preparamos un entrenador con datos válidos.
                var entrenador = new Entrenador
                {
                    Nombre = "Carlos Pérez", // Nombre válido
                    Correo = "carlos.perez@example.com", // Correo válido
                    Tipo = "Personal", // Tipo válido
                    PuntosFuertes = "Fuerza y resistencia" // Puntos fuertes válidos
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(entrenador, new ValidationContext(entrenador), resultadosValidacion, true);

                // Assert: Verificamos que el entrenador sea válido (sin errores).
                Assert.IsTrue(esValido); // Esperamos que sea válido
            }

            // Prueba que un entrenador con datos inválidos falle en la validación.
            [TestMethod]
            public void TestEntrenador_EntrenadorInvalido_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un entrenador con datos inválidos (supera las longitudes máximas).
                var entrenador = new Entrenador
                {
                    Nombre = "Carlos Pérez García Pérez García Pérez García Pérez García Pérez García", // Nombre demasiado largo (más de 50 caracteres)
                    Correo = "carlos.perez@example.com", // Correo válido
                    Tipo = "Personal", // Tipo válido
                    PuntosFuertes = "Fuerza y resistencia" // Puntos fuertes válidos
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(entrenador, new ValidationContext(entrenador), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido a los errores en el nombre.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el nombre)
            }

            // Prueba que un entrenador con campos requeridos vacíos falle en la validación.
            [TestMethod]
            public void TestEntrenador_FaltanCamposRequeridos_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un entrenador con campos requeridos vacíos.
                var entrenador = new Entrenador
                {
                    Nombre = null, // Falta el nombre (campo requerido)
                    Correo = null, // Falta el correo (campo requerido)
                    Tipo = "Personal", // Tipo válido
                    PuntosFuertes = "Fuerza y resistencia" // Puntos fuertes válidos
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(entrenador, new ValidationContext(entrenador), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido a los campos faltantes.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(2, resultadosValidacion.Count); // Esperamos 2 errores (por el nombre y el correo)
            }
        }

        [TestClass] 
        public sealed class TestFactura
        {
            // Prueba que una factura válida pase la validación.
            [TestMethod]
            public void TestFactura_FacturaValida_DeberiaPasarLaValidacion()
            {
                // Arrange: Preparamos una factura con datos válidos.
                var factura = new Factura
                {
                    Nombre = "Factura de ejercicio", // Nombre válido
                    Precio = 100.50m, // Precio válido
                    Tipo = "Mensualidad" // Tipo válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(factura, new ValidationContext(factura), resultadosValidacion, true);

                // Assert: Verificamos que la factura sea válida (sin errores).
                Assert.IsTrue(esValido); // Esperamos que sea válido
            }

            // Prueba que una factura con el precio inválido falle en la validación.
            [TestMethod]
            public void TestFactura_FacturaConPrecioInvalido_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos una factura con un precio inválido (precio negativo).
                var factura = new Factura
                {
                    Nombre = "Factura de ejercicio", // Nombre válido
                    Precio = -10.50m, // Precio inválido (negativo)
                    Tipo = "Mensualidad" // Tipo válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(factura, new ValidationContext(factura), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al precio negativo.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el precio)
            }

            // Prueba que una factura con un nombre demasiado largo falle en la validación.
            [TestMethod]
            public void TestFactura_FacturaConNombreLargo_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos una factura con un nombre demasiado largo (más de 100 caracteres).
                var factura = new Factura
                {
                    Nombre = new string('a', 101), // Nombre demasiado largo (más de 100 caracteres)
                    Precio = 100.50m, // Precio válido
                    Tipo = "Mensualidad" // Tipo válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(factura, new ValidationContext(factura), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al nombre largo.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el nombre)
            }

            // Prueba que una factura con campos obligatorios vacíos falle en la validación.
            [TestMethod]
            public void TestFactura_FaltanCamposRequeridos_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos una factura con campos obligatorios vacíos.
                var factura = new Factura
                {
                    Nombre = null, // Falta el nombre (campo requerido)
                    Precio = 0m, // Precio igual a 0 (debería ser mayor a 0)
                    Tipo = null // Falta el tipo (campo requerido)
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(factura, new ValidationContext(factura), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido a los campos faltantes.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(3, resultadosValidacion.Count); // Esperamos 3 errores (por el nombre, el precio y el tipo)
            }
        }

        [TestClass] 
        public sealed class TestHorario
        {
            // Prueba que un horario válido pase la validación.
            [TestMethod]
            public void TestHorario_HorarioValido_DeberiaPasarLaValidacion()
            {
                // Arrange: Preparamos un horario con datos válidos.
                var horario = new Horario
                {
                    NombreEntrenador = "Juan Pérez", // Nombre válido
                    HorarioClase = "10:00 AM - 11:00 AM", // Horario válido
                    PuntoFuerte = "Resistencia" // Punto fuerte válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(horario, new ValidationContext(horario), resultadosValidacion, true);

                // Assert: Verificamos que el horario sea válido (sin errores).
                Assert.IsTrue(esValido); // Esperamos que sea válido
            }

            // Prueba que un horario con un nombre de entrenador demasiado largo falle en la validación.
            [TestMethod]
            public void TestHorario_HorarioConNombreEntrenadorLargo_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un horario con un nombre de entrenador demasiado largo (más de 100 caracteres).
                var horario = new Horario
                {
                    NombreEntrenador = new string('a', 101), // Nombre de entrenador demasiado largo (más de 100 caracteres)
                    HorarioClase = "10:00 AM - 11:00 AM", // Horario válido
                    PuntoFuerte = "Resistencia" // Punto fuerte válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(horario, new ValidationContext(horario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al nombre del entrenador largo.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el nombre del entrenador)
            }

            // Prueba que un horario con un campo obligatorio vacío falle en la validación.
            [TestMethod]
            public void TestHorario_FaltanCamposRequeridos_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un horario con un campo obligatorio vacío (por ejemplo, el nombre del entrenador).
                var horario = new Horario
                {
                    NombreEntrenador = null, // Falta el nombre del entrenador (campo requerido)
                    HorarioClase = "10:00 AM - 11:00 AM", // Horario válido
                    PuntoFuerte = "Resistencia" // Punto fuerte válido
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(horario, new ValidationContext(horario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al campo obligatorio vacío.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el nombre del entrenador)
            }

            // Prueba que un horario con un punto fuerte demasiado largo falle en la validación.
            [TestMethod]
            public void TestHorario_HorarioConPuntoFuerteLargo_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un horario con un punto fuerte demasiado largo (más de 50 caracteres).
                var horario = new Horario
                {
                    NombreEntrenador = "Juan Pérez", // Nombre válido
                    HorarioClase = "10:00 AM - 11:00 AM", // Horario válido
                    PuntoFuerte = new string('a', 51) // Punto fuerte demasiado largo (más de 50 caracteres)
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(horario, new ValidationContext(horario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al punto fuerte largo.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el punto fuerte)
            }
        }

        [TestClass] 
        public sealed class TestInventario
        {
            // Prueba que un inventario válido pase la validación.
            [TestMethod]
            public void TestInventario_Valido_DeberiaPasarLaValidacion()
            {
                // Arrange: Preparamos un inventario con datos válidos.
                var inventario = new Inventario
                {
                    NombreMaquina = "Máquina de corte", // Nombre válido
                    VidaUtil = "5 años", // Vida útil válida
                    FechaCompra = new DateTime(2020, 01, 01) // Fecha de compra válida
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(inventario, new ValidationContext(inventario), resultadosValidacion, true);

                // Assert: Verificamos que el inventario sea válido (sin errores).
                Assert.IsTrue(esValido); // Esperamos que sea válido
            }

            // Prueba que un inventario con el nombre de máquina vacío falle en la validación.
            [TestMethod]
            public void TestInventario_SinNombreMaquina_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un inventario con el nombre de la máquina vacío.
                var inventario = new Inventario
                {
                    NombreMaquina = null, // Nombre de la máquina vacío (campo requerido)
                    VidaUtil = "5 años", // Vida útil válida
                    FechaCompra = new DateTime(2020, 01, 01) // Fecha de compra válida
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(inventario, new ValidationContext(inventario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al nombre de la máquina vacío.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el nombre de la máquina)
            }

            // Prueba que un inventario con la vida útil demasiado larga falle en la validación.
            [TestMethod]
            public void TestInventario_VidaUtilLarga_DeberiaFallarLaValidacion()
            {
                // Arrange: Preparamos un inventario con la vida útil demasiado larga (más de 50 caracteres).
                var inventario = new Inventario
                {
                    NombreMaquina = "Máquina de corte", // Nombre válido
                    VidaUtil = new string('a', 51), // Vida útil demasiado larga (más de 50 caracteres)
                    FechaCompra = new DateTime(2020, 01, 01) // Fecha de compra válida
                };

                // Act: Realizamos la validación.
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(inventario, new ValidationContext(inventario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido a la vida útil larga.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por la vida útil)
            }

            // Prueba que un inventario sin fecha de compra falle en la validación.
            [TestMethod]
            public void TestInventario_SinFechaCompra_DeberiaFallarLaValidacion()
            {
                // Arrange: .
                var inventario = new Inventario
                {
                    NombreMaquina = "Máquina de corte", // Nombre válido
                    VidaUtil = "5 años", // Vida útil válida
                    FechaCompra = default(DateTime) // Fecha de compra no válida (default es el 01/01/0001)
                };

                // Act: 
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(inventario, new ValidationContext(inventario), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido a la fecha de compra no válida.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por la fecha de compra)
            }
        }

        [TestClass] 
        public sealed class TestMatricula
        {
            // Prueba que una matricula válida pase la validación.
            [TestMethod]
            public void TestMatricula_Valida_DeberiaPasarLaValidacion()
            {
                // Arrange: Preparamos una matricula con datos válidos.
                var matricula = new Matricula
                {
                    ClienteId = 1, // ClienteId válido
                    HorarioId = 1, // HorarioId válido
                    NombreEntrenador = "Juan Pérez", // NombreEntrenador válido
                    PuntoFuerte = "Fuerza y resistencia" // PuntoFuerte válido
                };

                // Act: 
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(matricula, new ValidationContext(matricula), resultadosValidacion, true);

                // Assert: Verificamos que la matricula sea válida (sin errores).
                Assert.IsTrue(esValido); // Esperamos que sea válido
            }

            // Prueba que una matricula con ClienteId vacío falle en la validación.
            [TestMethod]
            public void TestMatricula_SinClienteId_DeberiaFallarLaValidacion()
            {
                // Arrange: 
                var matricula = new Matricula
                {
                    ClienteId = 0, // ClienteId inválido (debería ser mayor que 0)
                    HorarioId = 1, // HorarioId válido
                    NombreEntrenador = "Juan Pérez", // NombreEntrenador válido
                    PuntoFuerte = "Fuerza y resistencia" // PuntoFuerte válido
                };

                // Act: 
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(matricula, new ValidationContext(matricula), resultadosValidacion, true);

                // Assert: 
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el ClienteId)
            }

            // Prueba que una matricula con NombreEntrenador demasiado largo falle en la validación.
            [TestMethod]
            public void TestMatricula_NombreEntrenadorLargo_DeberiaFallarLaValidacion()
            {
                // Arrange: 
                var matricula = new Matricula
                {
                    ClienteId = 1, // ClienteId válido
                    HorarioId = 1, // HorarioId válido
                    NombreEntrenador = new string('a', 101), // NombreEntrenador demasiado largo (más de 100 caracteres)
                    PuntoFuerte = "Fuerza y resistencia" // PuntoFuerte válido
                };

                // Act: 
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(matricula, new ValidationContext(matricula), resultadosValidacion, true);

                // Assert: Verificamos que la validación falle debido al NombreEntrenador largo.
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el NombreEntrenador)
            }

            // Prueba que una matricula con PuntoFuerte vacío falle en la validación.
            [TestMethod]
            public void TestMatricula_SinPuntoFuerte_DeberiaFallarLaValidacion()
            {
                // Arrange: 
                var matricula = new Matricula
                {
                    ClienteId = 1, // ClienteId válido
                    HorarioId = 1, // HorarioId válido
                    NombreEntrenador = "Juan Pérez", // NombreEntrenador válido
                    PuntoFuerte = null // PuntoFuerte vacío
                };

                // Act: 
                var resultadosValidacion = new List<ValidationResult>(); // Lista para guardar los errores de validación
                var esValido = Validator.TryValidateObject(matricula, new ValidationContext(matricula), resultadosValidacion, true);

                // Assert: 
                Assert.IsFalse(esValido); // Esperamos que sea inválido
                Assert.AreEqual(1, resultadosValidacion.Count); // Esperamos 1 error (por el PuntoFuerte)
            }
        }

    }

}