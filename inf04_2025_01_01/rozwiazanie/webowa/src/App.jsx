import { useCallback, useMemo, useState } from "react";
import { CATEGORIES, CATEGORIES_ORDER, IMAGES } from "./data";

export default function App() {
  const [images, setImages] = useState(IMAGES);
  const [categories, setCategories] = useState(new Set(CATEGORIES_ORDER));

  const selectedImages = useMemo(
    () => images.filter(({ category }) => categories.has(category)),
    [images, categories],
  );

  const handleDownload = useCallback(
    (id) =>
      setImages((prev) =>
        prev.map((image) =>
          image.id === id
            ? { ...image, downloads: image.downloads + 1 }
            : image,
        ),
      ),
    [],
  );

  const handleSwitchChange = useCallback((e) => {
    const checked = e.currentTarget.checked;
    const category = parseInt(e.currentTarget.id.split("-")[1]);

    setCategories((prev) => {
      const clone = new Set(prev);
      if (checked) clone.add(category);
      else clone.delete(category);
      return clone;
    });
  }, []);

  return (
    <main className="container">
      <h1>Kategorie zdjęć</h1>

      <div className="row">
        {CATEGORIES_ORDER.map((key) => {
          const htmlId = `category-${key}`;

          return (
            <div key={key} className="col-auto">
              <div className="form-check form-switch">
                <input
                  className="form-check-input"
                  type="checkbox"
                  id={htmlId}
                  onChange={handleSwitchChange}
                  defaultChecked
                />

                <label className="form-check-label" htmlFor={htmlId}>
                  {CATEGORIES[key]}
                </label>
              </div>
            </div>
          );
        })}
      </div>

      <div className="row row-cols-3">
        {selectedImages.map(({ id, alt, filename, downloads }) => {
          const imageSource = `/assets/${filename}`;

          return (
            <article key={id} className="col p-0">
              <div style={{ margin: "5px" }}>
                <img className="w-100 rounded" src={imageSource} alt={alt} />

                <h4>Pobrań: {downloads}</h4>

                <button
                  className="btn btn-success"
                  onClick={() => handleDownload(id)}
                >
                  Pobierz
                </button>
              </div>
            </article>
          );
        })}
      </div>
    </main>
  );
}
