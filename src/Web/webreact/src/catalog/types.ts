// Define the Catalog Item type.
export interface ICatalogItem {
  code: number;
  name: string;
  imageUrl: string;
  description: string;
  price: number;
  brand: string;
  colour: string;
  width: number;
  height: number;
  thickness: number;
  weight: number;
  processor: string;
  screen: number;
  frontCamera: number;
  rearCamera: number;
  battery: number;
  internalMemory: number;
  ramMemory: number;
  operatingSystem: string;
}

// Define the Catalog Item state.
export interface ICatalogItemState {
  catalogItems: ICatalogItem[];
  activeCatalogItem: null | ICatalogItem;
  loading: boolean;
}
