-- Restricción de mínimo de caracteres
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('Mínimo de caracteres', 6, 0, 1);

-- Combinar mayúsculas y minúsculas
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('Combinar mayúsculas y minúsculas', NULL, 0, 1);

-- Contener números y letras
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('Contener números y letras', NULL, 0, 1);

-- Contener un carácter especial
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('Contener un carácter especial', NULL, 0, 1);

-- No repetir contraseñas anteriores
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('No repetir contraseñas anteriores', NULL, 0, 1);

-- No permitir datos personales
INSERT INTO Restricciones (Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('No permitir datos personales', NULL, 0, 1);

-- Requerir autenticación en dos pasos (2FA) por correo electrónico
INSERT INTO Restricciones(Restriccion, Caracteres_Min, Activo, Id_Tipo)
VALUES ('Requerir autenticación en dos pasos (2FA) por correo electrónico', NULL, 0, 2);
