import { useRef } from "react";

export default function Form() {
  const titleInputRef = useRef(null);
  const genreSelectRef = useRef(null);

  const handleSubmit = (e) => {
    e.preventDefault();

    const title = titleInputRef.current.value;
    const genre = genreSelectRef.current.value;

    console.log(`tytul: ${title}, rodzaj: ${genre}`);
  };

  return (
    <form onSubmit={handleSubmit}>
      <div className="form-group mb-3">
        <label className="mb-2" htmlFor="title">
          Tytuł filmu
        </label>

        <input
          ref={titleInputRef}
          className="form-control"
          id="title"
          type="text"
          required
        />
      </div>

      <div className="form-group mb-3">
        <label className="mb-2" htmlFor="genre">
          Rodzaj
        </label>

        <select
          ref={genreSelectRef}
          className="form-select"
          id="genre"
          required
        >
          <option></option>
          <option value="1">Komedia</option>
          <option value="2">Obyczajowy</option>
          <option value="3">Sensacyjny</option>
          <option value="4">Horror</option>
        </select>
      </div>

      <button className="btn btn-primary">Dodaj</button>
    </form>
  );
}
