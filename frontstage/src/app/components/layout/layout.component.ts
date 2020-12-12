import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  public searchKeyword: string;
  constructor() {
    this.searchKeyword = '';
  }

  ngOnInit(): void {
  }

}
