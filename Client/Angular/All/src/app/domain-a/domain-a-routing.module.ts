import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DomainAComponent } from './domain-a.component';
import { Feature1Component } from './feature-1/feature-1.component';
import { Feature2Component } from './feature-2/feature-2.component';

import { DomainA1Component } from './domain-a1/domain-a1.component';
import { Featuer1Component as DomainA1Featuer1Component } from './domain-a1/featuer-1/featuer-1.component';
import { Featuer2Component as DomainA1Featuer2Component } from './domain-a1/featuer-2/featuer-2.component';

const routes: Routes = [
  {
    path: 'domain-a',
    component: DomainAComponent,
    children: [
      { path: 'feature-1', component: Feature1Component },
      { path: 'feature-2', component: Feature2Component },
      {
        path: 'domain-a1', component: DomainA1Component,
        children: [
          { path: 'feature-1', component: DomainA1Featuer1Component },
          { path: 'feature-2', component: DomainA1Featuer2Component },
        ]
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DomainARoutingModule { }
