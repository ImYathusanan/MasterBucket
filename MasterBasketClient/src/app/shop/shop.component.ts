import { IProduct } from '../shared/models/product';
import { ShopService } from './shop.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit {

  products: IProduct[];

  constructor(private shopService: ShopService) { }

  ngOnInit(): void {

    this.shopService.getProducts().subscribe((responce: any) => {
        this.products = responce;
    }, error => {
      console.log(error);
    });
  }

}
