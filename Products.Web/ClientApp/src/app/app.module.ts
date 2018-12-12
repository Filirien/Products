import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { UserProductsComponent } from './product/user-products/user-products.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    UserProductsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'products', component: UserProductsComponent }
    ])
  ],
  providers: [ ],
  bootstrap: [AppComponent]
})
export class AppModule { }
