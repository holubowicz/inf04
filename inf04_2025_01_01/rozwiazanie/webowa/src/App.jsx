import { useCallback, useMemo, useState } from "react";

// prettier-ignore
const IMAGES = [
  { id: 0,  alt: "Mak",           filename: "obraz1.jpg",  category: 1, downloads: 35  },
  { id: 1,  alt: "Bukiet",        filename: "obraz2.jpg",  category: 1, downloads: 43  },
  { id: 2,  alt: "Dalmatyńczyk",  filename: "obraz3.jpg",  category: 2, downloads: 2   },
  { id: 3,  alt: "Świnka morska", filename: "obraz4.jpg",  category: 2, downloads: 53  },
  { id: 4,  alt: "Rotwailer",     filename: "obraz5.jpg",  category: 2, downloads: 43  },
  { id: 5,  alt: "Audi",          filename: "obraz6.jpg",  category: 3, downloads: 11  },
  { id: 6,  alt: "kotki",         filename: "obraz7.jpg",  category: 2, downloads: 22  },
  { id: 7,  alt: "Róża",          filename: "obraz8.jpg",  category: 1, downloads: 33  },
  { id: 8,  alt: "Świnka morska", filename: "obraz9.jpg",  category: 2, downloads: 123 },
  { id: 9,  alt: "Foksterier",    filename: "obraz10.jpg", category: 2, downloads: 22  },
  { id: 10, alt: "Szczeniak",     filename: "obraz11.jpg", category: 2, downloads: 12  },
  { id: 11, alt: "Garbus",        filename: "obraz12.jpg", category: 3, downloads: 321 },
];

const CATEGORIES = Object.freeze({
  1: "Kwiaty",
  2: "Zwierzęta",
  3: "Samochody",
});

const CATEGORY_KEYS = Object.keys(CATEGORIES).map((x) => parseInt(x));

export default function App() {
  const [images, setImages] = useState(IMAGES);
  const [selectedCategories, setSelectedCategories] = useState(
    new Set(CATEGORY_KEYS),
  );

  const filteredImages = useMemo(
    () => images.filter((image) => selectedCategories.has(image.category)),
    [images, selectedCategories],
  );

  const handleCategorySwitch = useCallback(
    (key) => {
      const next = new Set(selectedCategories);

      if (next.has(key)) {
        next.delete(key);
      } else {
        next.add(key);
      }

      setSelectedCategories(next);
    },
    [selectedCategories],
  );

  const handleDownloadImage = useCallback((id) => {
    setImages((prev) =>
      prev.map((element) =>
        element.id == id
          ? { ...element, downloads: element.downloads + 1 }
          : element,
      ),
    );
  }, []);

  return (
    <div className="container my-4">
      <h1>Kategorie zdjęć</h1>

      <div className="d-flex gap-4">
        {CATEGORY_KEYS.map((key) => {
          const id = `category-${key}`;

          return (
            <div key={id} className="form-check form-switch">
              <input
                className="form-check-input"
                onChange={() => handleCategorySwitch(key)}
                id={id}
                type="checkbox"
                defaultChecked
              />

              <label className="form-check-label" htmlFor={id}>
                {CATEGORIES[key]}
              </label>
            </div>
          );
        })}
      </div>

      <main className="row row-cols-3">
        {filteredImages.map((image) => (
          <article key={image.id} className="p-0">
            <div style={{ margin: "5px" }}>
              <img
                className="rounded w-100"
                src={`assets/${image.filename}`}
                alt={image.alt}
              />

              <h4>Pobrań: {image.downloads}</h4>

              <button
                className="btn btn-success"
                onClick={() => handleDownloadImage(image.id)}
              >
                Pobierz
              </button>
            </div>
          </article>
        ))}
      </main>
    </div>
  );
}
