import { Component, OnInit } from '@angular/core';
import { ElMessageService } from 'element-angular'

@Component({
  selector: 'app-certification',
  templateUrl: './certification.component.html',
  styleUrls: ['./certification.component.css']
})
export class CertificationComponent implements OnInit {

  public country: [
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
  ];
  public level: Number = 1;
  constructor(
    private message: ElMessageService
  ) { 
    this.country = [
      {
        value:'cn',
        name: '中国(+86)'
      },
      {
        value:'cn-tw',
        name: '中国台湾(+886)'
      },
      {
        value:'cn-hg',
        name: '中国香港(+852)'
      },
      {
        value:'au',
        name: '澳大利亚(+061)'
      },
      {
        value:'usa',
        name: '美国(+001)'
      },
      {
        value:'jpn',
        name: '日本(+081)'
      },
      {
        value:'can',
        name: '加拿大(+001)'
      },
      {
        value:'kor',
        name: '韩国(+082)'
      }
    ]
  }

  ngOnInit(): void {
  }

  submit(type: string): void{
    this.level = 2;
    this.message[type]('请串接 api ' + type);
  }
}
