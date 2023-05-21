USE Ejercicio2

-- llenar Pais
INSERT INTO Pais (nombre, n_participantes, n_medallas)
VALUES
  ('Argentina', '100', '10'),
  ('Brazil', '200', '15'),
  ('Canada', '150', '8'),
  ('Denmark', '180', '12'),
  ('Egypt', '120', '5'),
  ('France', '90', '3'),
  ('Germany', '250', '20'),
  ('Hungary', '300', '25'),
  ('India', '80', '2'),
  ('Japan', '200', '18'),
  ('Kenya', '160', '6'),
  ('Mexico', '130', '9'),
  ('Netherlands', '220', '14'),
  ('Portugal', '190', '11'),
  ('Sweden', '140', '7');
COMMIT;

INSERT INTO Deportista (nombre, apellido, sexo, pais)
VALUES
  ('John', 'Doe', 'Male', 'Argentina'),
  ('Alice', 'Smith', 'Female', 'Brazil'),
  ('Michael', 'Johnson', 'Male', 'Canada'),
  ('Maria', 'Garcia', 'Female', 'Denmark'),
  ('David', 'Lee', 'Male', 'Egypt'),
  ('Emma', 'Brown', 'Female', 'France'),
  ('Daniel', 'Chen', 'Male', 'Germany'),
  ('Sophia', 'Lopez', 'Female', 'Hungary'),
  ('James', 'Nguyen', 'Male', 'India'),
  ('Olivia', 'Wang', 'Female', 'Japan'),
  ('William', 'Kim', 'Male', 'Kenya'),
  ('Isabella', 'Gupta', 'Female', 'Mexico'),
  ('Benjamin', 'Silva', 'Male', 'Netherlands'),
  ('Mia', 'Martinez', 'Female', 'Portugal '),
  ('Ethan', 'Sato', 'Male', 'Sweden');
  
INSERT INTO Prueba (disciplina, lugar, n_deporIns, naturaleza)
VALUES
  ('Running', 'New York', '10', 'Outdoor'),
  ('Swimming', 'Los Angeles', '8', 'Indoor'),
  ('Cycling', 'London', '12', 'Outdoor'),
  ('Basketball', 'Chicago', '6', 'Indoor'),
  ('Tennis', 'Paris', '4', 'Outdoor'),
  ('Gymnastics', 'Tokyo', '6', 'Indoor'),
  ('Soccer', 'Madrid', '12', 'Outdoor'),
  ('Volleyball', 'Rio de Janeiro', '8', 'Indoor'),
  ('Baseball', 'New York', '6', 'Outdoor'),
  ('Golf', 'Scottsdale', '4', 'Outdoor'),
  ('Weightlifting', 'Beijing', '8', 'Indoor'),
  ('Skiing', 'Vancouver', '6', 'Outdoor'),
  ('Boxing', 'Las Vegas', '4', 'Indoor'),
  ('Rowing', 'Amsterdam', '6', 'Outdoor'),
  ('Table Tennis', 'Seoul', '4', 'Indoor');