import { Component } from '@angular/core';
import { LayoutComponent } from './components/layout/layout.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})

export class AppComponent {

  public loading: boolean = true;
  ngDoCheck(){
    this.loading = false;
    let loadNode = document.getElementById('loadNode');
    loadNode.setAttribute('style','display:none');
  }

  title = 'Shopanda';
}
