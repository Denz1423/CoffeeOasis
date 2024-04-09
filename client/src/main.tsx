import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { router } from "./router/Routes.tsx";
import { Provider } from "react-redux";
import { store } from "./store/configureStore.ts";
import { RouterProvider } from "react-router-dom";
import 'slick-carousel/slick/slick.css'
import 'slick-carousel/slick/slick-theme.css'

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <Provider store={store}>
      <RouterProvider router={router} />
    </Provider>
  </React.StrictMode>
);
