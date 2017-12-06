import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DisplayingDataComponent } from './displaying-data/displaying-data.component';
import { StructuralDirectivesComponent } from './structural-directives/structural-directives.component';
import { PipesComponent } from './pipes/pipes.component';
import {
  ComponentInteractionComponent,
  ComponentInteractionComponentInputChild,
  ComponentInteractionComponentTwowayChild,
  ComponentInteractionComponentReferenceChild,
  ComponentInteractionComponentViewChild
} from './component-interaction/component-interaction.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    DisplayingDataComponent,
    StructuralDirectivesComponent,
    PipesComponent,
    ComponentInteractionComponent,
    ComponentInteractionComponentInputChild,
    ComponentInteractionComponentTwowayChild,
    ComponentInteractionComponentReferenceChild,
    ComponentInteractionComponentViewChild
  ],
})
export class TemplateDataBindingModule { }
