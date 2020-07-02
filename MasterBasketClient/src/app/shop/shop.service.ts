import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  private endPoint = "https://localhost:44348/api/";

  constructor(private http: HttpClient) { }

  getProducts() {
    return this.http.get(this.endPoint + 'products');
  }


}
