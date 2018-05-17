import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DomainBRoutingModule } from './domain-b-routing.module';
import { DomainBComponent } from './domain-b.component';
import { Feature1Component } from './feature-1/feature-1.component';
import { Feature2Component } from './feature-2/feature-2.component';

@NgModule({
  imports: [
    CommonModule,
    DomainBRoutingModule
  ],
  declarations: [DomainBComponent, Feature1Component, Feature2Component]
})
export class DomainBModule { }
