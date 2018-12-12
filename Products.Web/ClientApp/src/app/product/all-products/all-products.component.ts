import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductModel } from '../models/product-model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-all-products',
  templateUrl: './all-products.component.html',
  styleUrls: ['./all-products.component.css']
})

export class AllProductsComponent {

  public products: ProductModel[];

  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<ProductModel[]>(baseUrl + 'api/products/allproducts')
      .subscribe(result => {
        this.products = result;
      }, error => console.error(error));
  }

  onSubmit(id: number) {
    this.http.get<ProductModel[]>(this.baseUrl + 'api/products/allproducts')
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
}
