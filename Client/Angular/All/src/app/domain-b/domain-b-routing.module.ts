import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DomainBComponent } from './domain-b.component';
import { Feature1Component } from './feature-1/feature-1.component';
import { Feature2Component } from './feature-2/feature-2.component';


const routes: Routes = [
  {
    path: '',
    component: DomainBComponent,
    children: [
      { path: 'feature-1', component: Feature1Component },
      { path: 'feature-2', component: Feature2Component },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DomainBRoutingModule { }
