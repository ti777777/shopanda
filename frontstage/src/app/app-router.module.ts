import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule , Routes} from '@angular/router';

/*引入组件*/
import { ShopandaIndexComponent } from './components/shopanda-index/shopanda-index.component';

const appRouters: Routes = [
  { path: 'index' , component: ShopandaIndexComponent }
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
