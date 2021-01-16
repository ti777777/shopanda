import { Component, OnInit } from '@angular/core';
import { lookup } from 'dns';
import "owl.carousel2";
declare var $: any;
import { ProductDetail } from '../../class/product-detail';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  owlCarouselOptions: Object; // 宣告 Owl Carousel 的 Options
  public CarouselImage: [string,string,string];
  public productArr: Array<ProductDetail>;
  constructor() {
    this.CarouselImage = [
      'assets/banner-mate40.png','assets/banner1.png','assets/banner2.png'
    ];
    // 暂时用假资料测试
    this.productArr = [
      {
        product_pic: '/assets/1.png',
        name: 'HUAWEI Mate 40 Pro+ 5G 全网通 12G...',
        description: '5nm麒麟9000旗舰芯片 | 超感光徕卡电...',
        price: 7988
      },
      {
        product_pic: '/assets/2.png',
        name: 'HUAWEI Mate 40 Pro 全网通5G手机 8GB...',
        description: '5nm麒麟9000旗舰芯片 | 超感光徕卡电...',
        price: 6488
      },
      {
        product_pic: '/assets/3.png',
        name: '华为 HUAWEI P40 冰霜银 全网通5G手机',
        description: '麒麟990 5G SoC芯片 5000万超感...',
        price: 4399
      },
      {
        product_pic: '/assets/3.png',
        name: '华为 HUAWEI P40 冰霜银 全网通5G手机',
        description: '麒麟990 5G SoC芯片 5000万超感...',
        price: 4399
      },
      {
        product_pic: '/assets/3.png',
        name: '华为 HUAWEI P40 冰霜银 全网通5G手机',
        description: '麒麟990 5G SoC芯片 5000万超感...',
        price: 4399
      },
    ]
   }

  ngOnInit(): void {
    this.createCarousel();
  }

  // index header carousel
  createCarousel(): void{
    $('.carousel .owl-carousel').owlCarousel({
      loop:true,
      margin:10,
      autoplay:true,
      autoplayTimeout:3000,
      autoplayHoverPause:true,
      responsive:{
          0:{
              items:1,
              loop: true
          },
          600:{
              items:1,
              loop: true
          },
          1000:{
              items:1,
              loop: true
          }
      }
    })
  }
}
