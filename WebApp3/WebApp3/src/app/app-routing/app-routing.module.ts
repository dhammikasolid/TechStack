import { NgModule } from '@angular/core';

import { Routes, RouterModule } from '@angular/router';

import { DisplayingDataComponent } from '../template-data-binding/displaying-data/displaying-data.component';
import { StructuralDirectivesComponent } from '../template-data-binding/structural-directives/structural-directives.component';
import { PipesComponent } from '../template-data-binding/pipes/pipes.component';
import { ComponentInteractionComponent } from '../template-data-binding/component-interaction/component-interaction.component';

let routes: Routes = [
  {
    path: 'template-data-binding',
    children: [
      { path: 'displaying-data', component: DisplayingDataComponent },
      { path: 'structural-directives', component: StructuralDirectivesComponent },
      { path: 'pipes', component: PipesComponent },
      { path: 'component-interaction', component: ComponentInteractionComponent },
    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  declarations: []
})
export class AppRoutingModule { }
