import { Component, OnInit } from '@angular/core';
import { IProduct } from '../app/shared/models/product';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MasterBasketClient';
  

  constructor() {
  }

  ngOnInit(): void {
  }
}
