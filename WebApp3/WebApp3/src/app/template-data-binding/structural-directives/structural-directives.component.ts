import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-structural-directives',
  templateUrl: './structural-directives.component.html',
  styleUrls: ['./structural-directives.component.css']
})
export class StructuralDirectivesComponent {

  collection = [
    { id: 1, val: 'v1' },
    { id: 2, val: 'v2' },
    { id: 3, val: 'v3' },
  ];

  trackBy(index, item) {
    return item.id;
  }

  changeCollection() {
    this.collection = this.getCollection();
  }

  changeCollectionItem() {
    this.collection[1].val = '***';
  }

  getCollection() {
    return [
      { id: 1, val: 'v1' },
      { id: 2, val: 'v2' },
      { id: 3, val: 'v3' },
    ];
  }

  switchs = ['a', 'b', 'c']
  switch = 'a';
  switchIndex = 0;

  changeSwitch() {
    this.switch = this.switchs[this.switchIndex];
    this.switchIndex = this.switchIndex == 2 ? 0 : this.switchIndex + 1;
  }

}
