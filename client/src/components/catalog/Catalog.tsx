import { useState, useEffect } from "react";
import { Product } from "../../models/product";
import ProductList from "./ProductList";
import agent from "../../api/agent";
import Loading from "../loading";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Catalog.list()
      .then((products) => setProducts(products))
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, []);

  if (loading) return <Loading />;

  return (
    <>
      <ProductList products={products} />
    </>
  );
}
