import { useRef } from "react";

export default function App() {
  const courses = [
    "Programowanie w C#",
    "Angular dla początkujących",
    "Kurs Django",
  ];

  const fullNameInputRef = useRef(null);
  const courseNumberInputRef = useRef(null);

  const handleSubmit = (e) => {
    e.preventDefault();

    const fullName = fullNameInputRef.current.value;
    const courseIndex = parseInt(courseNumberInputRef.current.value) - 1;

    console.log(fullName);
    console.log(
      courseIndex < 0 || courseIndex >= courses.length
        ? "Nieprawidłowy numer kursu"
        : courses[courseIndex],
    );
  };

  return (
    <div className="container mt-4">
      <h2>Liczba kursów: {courses.length}</h2>

      <ol>
        {courses.map((course) => (
          <li>{course}</li>
        ))}
      </ol>

      <form onSubmit={handleSubmit}>
        <div className="form-group mb-3">
          <label className="mb-2" htmlFor="fullName">
            Imię i nazwisko
          </label>

          <input
            ref={fullNameInputRef}
            className="form-control"
            id="fullName"
            type="text"
          />
        </div>

        <div className="form-group mb-3">
          <label className="mb-2" htmlFor="courseNumber">
            Numer kursu
          </label>

          <input
            ref={courseNumberInputRef}
            className="form-control"
            id="courseNumber"
            type="number"
          />
        </div>

        <button className="btn btn-primary">Zapisz do kursu</button>
      </form>
    </div>
  );
}
