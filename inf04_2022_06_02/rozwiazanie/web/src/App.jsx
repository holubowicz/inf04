import { useCallback, useMemo, useRef } from "react";

export default function App() {
  const fullnameRef = useRef(null);
  const courseNumberRef = useRef(null);

  const courses = useMemo(
    () => ["Programowanie w C#", "Angular dla początkujących", "Kurs Django"],
    [],
  );

  const handleSubmit = useCallback(
    (e) => {
      e.preventDefault();

      const courseNumber = parseInt(courseNumberRef.current.value) - 1;

      console.log(fullnameRef.current.value);
      console.log(courses[courseNumber] ?? "Nieprawidłowy numer kursu");
    },
    [courses],
  );

  return (
    <div className="container mt-4">
      <h2>Liczba kursów: {courses.length}</h2>

      <ol>
        {courses.map((course) => (
          <li key={course}>{course}</li>
        ))}
      </ol>

      <form onSubmit={handleSubmit}>
        <div className="mb-3">
          <label className="form-label" htmlFor="fullname">
            Imię i nazwisko:
          </label>

          <input
            ref={fullnameRef}
            className="form-control"
            id="fullname"
            type="text"
            required
          />
        </div>

        <div className="mb-3">
          <label className="form-label" htmlFor="courseNumber">
            Numer kursu:
          </label>

          <input
            ref={courseNumberRef}
            className="form-control"
            id="courseNumber"
            type="number"
            required
          />
        </div>

        <button className="btn btn-primary">Zapisz do kursu</button>
      </form>
    </div>
  );
}
