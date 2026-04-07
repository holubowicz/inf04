import { useCallback, useRef } from "react";

const GENRES = [
  { label: "" },
  { label: "Komedia", value: 1 },
  { label: "Obyczajowy", value: 2 },
  { label: "Sensacyjny", value: 3 },
  { label: "Horror", value: 4 },
];

export default function FilmForm() {
  const titleRef = useRef(null);
  const genreRef = useRef(null);

  const handleSubmit = useCallback((e) => {
    e.preventDefault();

    const title = titleRef.current.value;
    const genre = genreRef.current.value;

    console.log(`tytul: ${title}; rodzaj: ${genre}`);
  }, []);

  return (
    <form onSubmit={handleSubmit}>
      <div className="mb-3">
        <label className="form-label" htmlFor="title">
          Tytuł filmu
        </label>

        <input
          ref={titleRef}
          className="form-control"
          id="title"
          type="text"
          required
        />
      </div>

      <div className="mb-3">
        <label className="form-label" htmlFor="genre">
          Rodzaj
        </label>

        <select ref={genreRef} className="form-select" id="genre" required>
          {GENRES.map(({ label, value }) => (
            <option key={label} value={value}>
              {label}
            </option>
          ))}
        </select>
      </div>

      <button className="btn btn-primary">Dodaj</button>
    </form>
  );
}
