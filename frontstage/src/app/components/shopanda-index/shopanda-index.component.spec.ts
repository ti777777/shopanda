import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShopandaIndexComponent } from './shopanda-index.component';

describe('ShopandaIndexComponent', () => {
  let component: ShopandaIndexComponent;
  let fixture: ComponentFixture<ShopandaIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShopandaIndexComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShopandaIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
