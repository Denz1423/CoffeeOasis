import { useEffect } from "react";
import ProductList from "./ProductList";
import { useAppDispatch, useAppSelector } from "../../store/configureStore";
import { fetchProductsAsync, productSelectors } from "./catalogSlice";
import Loading from "../Loading";

export default function Catalog() {
  const products = useAppSelector(productSelectors.selectAll);
  const { productsLoaded, status } = useAppSelector((state) => state.catalog);
  const dispatch = useAppDispatch();

  useEffect(() => {
    if (!productsLoaded) dispatch(fetchProductsAsync());
  }, [dispatch, productsLoaded]);

  if(status.includes('pending')) return <Loading message='Loading products...' />

  return (
    <>
      <ProductList products={products} />
    </>
  );
}
