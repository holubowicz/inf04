import { useCallback } from "react";

const GENRES = [
  { label: "" },
  { label: "Komedia", value: 1 },
  { label: "Obyczajowy", value: 2 },
  { label: "Sensacyjny", value: 3 },
  { label: "Horror", value: 4 },
];

export default function FilmForm() {
  const handleSubmit = useCallback((e) => {
    e.preventDefault();

    const formData = new FormData(e.currentTarget);
    const title = formData.get("title");
    const genre = formData.get("genre");

    console.log(`tytul: ${title}; rodzaj: ${genre}`);
  }, []);

  return (
    <form onSubmit={handleSubmit}>
      <div className="mb-3">
        <label className="form-label" htmlFor="title">
          Tytuł filmu
        </label>

        <input
          className="form-control"
          id="title"
          name="title"
          type="text"
          required
        />
      </div>

      <div className="mb-3">
        <label className="form-label" htmlFor="genre">
          Rodzaj
        </label>

        <select className="form-select" id="genre" name="genre" required>
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
