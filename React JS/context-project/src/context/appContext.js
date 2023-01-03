import { createContext, useContext, useState } from "react";

const AppContext = createContext();

export const useAppContext = () => {
  const context = useContext(AppContext);

  return context;
};

const AppContextProvider = ({ children }) => {
  const [favoriler, setFavoriler] = useState([]);

  const favorilereEkle = (kitap) => {
    const eskiFavoriler = [...favoriler];
    const yeniFavoriler = eskiFavoriler.concat(kitap);

    setFavoriler(yeniFavoriler);
  };

  const favorilerdenSil = (id) => {
    const eskiFavoriler = [...favoriler];
    const yeniFavoriler = eskiFavoriler.filter((book) => book.id !== id);

    setFavoriler(yeniFavoriler);
  };

  return (
    <AppContext.Provider value={{ favoriler, favorilereEkle, favorilerdenSil }}>
      {children}
    </AppContext.Provider>
  );
};

export default AppContextProvider;
