import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AppRouterModule } from './app-router.module';

/*引入组件*/
import { ShopandaIndexComponent } from './components/shopanda-index/shopanda-index.component';

@NgModule({
  declarations: [
    AppComponent,
    ShopandaIndexComponent
  ],
  imports: [
    BrowserModule,
    AppRouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
