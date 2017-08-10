import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ContainerComponent } from './components/container.component';

const routes: Routes = [
    { path: 'b', component: ContainerComponent }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes),
    ],
})
export class RoutingModule { }
