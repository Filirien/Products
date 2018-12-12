import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductModel } from '../models/product-model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-user-products',
  templateUrl: './user-products.component.html',
  styleUrls: ['./user-products.component.css']
})

export class UserProductsComponent {

  products: ProductModel[];
  searchProducts: ProductModel[];
  isSearch = false;

  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    //http.get<ProductModel[]>(baseUrl + 'api/products/allproducts')
    //  .subscribe(result => {
    //  this.products = result;
    //}, error => console.error(error));
  }

  onSubmit(id: number = 0) {
    this.http.get<ProductModel[]>(this.baseUrl + 'api/products?userId=' + id)
      .pipe(map(x => x.filter(product => product.userId == id)))
      .subscribe(result => {
        this.products = result;
      }, error => console.error(error));
  }

  sortTypeAsce() {
    this.products.sort((a, b) => a.type > b.type ? 1 : -1);
  }

  sortTypeDesc() {
    this.products.sort((a, b) => a.type > b.type ? -1 : 1);
  }

  sortDescriptionAsce() {
    this.products.sort((a, b) => a.description > b.description ? 1 : -1);
  }

  sortDescriptionDesc() {
    this.products.sort((a, b) => a.description > b.description ? -1 : 1);
  }

  search(name: string) {
    this.searchProducts = this.products.filter(a => a.type.includes(name) || a.description.includes(name));
    this.isSearch = true;
  }
}
