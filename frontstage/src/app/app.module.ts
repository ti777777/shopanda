import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AppRouterModule } from './app-router.module';
import { IndexComponent } from './components/index/index.component';
import { ProductComponent } from './components/product/product.component';
import { ShoppingCartComponent } from './components/shopping-cart/shopping-cart.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { LayoutComponent } from './components/layout/layout.component';
import { ElModule } from 'element-angular';
import { SearchComponent } from './components/search/search.component';
import { OwlcarouselDirective } from './owlcarousel.directive';
import { FormsModule,ReactiveFormsModule } from "@angular/forms";

/*引入组件*/


@NgModule({
  declarations: [
    AppComponent,
    IndexComponent,
    ProductComponent,
    ShoppingCartComponent,
    LoginComponent,
    RegisterComponent,
    LayoutComponent,
    SearchComponent,
    OwlcarouselDirective
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRouterModule,
    FormsModule,
    ReactiveFormsModule,
    ElModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
