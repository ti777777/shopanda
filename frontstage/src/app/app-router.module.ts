import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule , Routes} from '@angular/router';

/*引入组件*/
import { IndexComponent } from './components/index/index.component';
import { LoginComponent} from './components/login/login.component';
import { ProductComponent } from './components/product/product.component';
import { RegisterComponent } from './components/register/register.component';
import { ShoppingCartComponent } from './components/shopping-cart/shopping-cart.component';

const appRouters: Routes = [
  { path: '' , component: IndexComponent },
  { path: 'login' , component: LoginComponent },
  { path: 'products' , component: ProductComponent },
  { path: 'register' , component: RegisterComponent },
  { path: 'shoppingcart' , component: ShoppingCartComponent }
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(appRouters)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRouterModule { }
