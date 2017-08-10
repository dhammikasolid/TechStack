import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RoutingModule } from './routing.module';
import { ContainerComponent } from './components/container.component';
import { ListComponent } from './components/list.component';

@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    exports: [
        ContainerComponent,
    ],
    imports: [
        BrowserModule,
        RoutingModule
    ],
})
export class Module { }
