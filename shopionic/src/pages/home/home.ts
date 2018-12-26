import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { ListPage } from '../list/list';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  private Amount: number;
  private Price: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }
  Add() {
    this.navCtrl.push(ListPage)
    this.http.post("https://localhost:5001/api/Order",
      {
        Amount: this.Amount,
        Price: this.Price,
      }).subscribe(
        it => {
          // SUCCESS: Do something
          console.log('success')
        },
        error => {
          // ERROR: Do something
          console.log("fail")
        });
  }

}
