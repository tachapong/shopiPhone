import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { orders } from '../../models/orders';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {
  orders: orders[];

  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
   
    }
    ionViewDidEnter(){
      this.http.get<orders[]>("https://localhost:5001/api/Order").subscribe(
        it => {
          this.orders = it;
        
        });
    }
  
}
