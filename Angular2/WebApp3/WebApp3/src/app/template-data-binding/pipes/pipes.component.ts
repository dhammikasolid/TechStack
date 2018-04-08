import { Component, OnInit, OnChanges, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit, OnDestroy {

  date = new Date();

  ngOnInit() {
    console.log('PipesComponent: Init');
  }

  ngOnDestroy() {
    console.log('PipesComponent: Destroy');
  }
}
