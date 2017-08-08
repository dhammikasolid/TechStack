import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ContainerComponent } from './components/container.component';
import { ListComponent } from './components/list.component';

@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    exports: [
        ContainerComponent
    ],
    imports: [
        BrowserModule,
    ],
})
export class Module { }
