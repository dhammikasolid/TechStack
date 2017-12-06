import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-displaying-data',
  templateUrl: './displaying-data.component.html',
  styleUrls: ['./displaying-data.component.css']
})
export class DisplayingDataComponent implements OnInit {

  selectedItem = '';

  property = '*';

  collection = [
    { prop1: 'prop11', prop2: 'prop21' },
    { prop1: 'prop12', prop2: 'prop22' },
    { prop1: 'prop13', prop2: 'prop23' },
  ];

  eventHandler1() {
    this.property = this.property + ' *';
  }

  eventHandlerArgs(item) {
    this.selectedItem = item;
  }

  deactive = false;

  eventHandler2() {
    this.deactive = !this.deactive;
  }

  constructor() { }

  ngOnInit() {
  }

}
