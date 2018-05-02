import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PageNotFoundComponent } from './app-common/page-not-found/page-not-found.component';
import { DashbordComponent } from './app-common/dashbord/dashbord.component';

let routes: Routes = [
  { path: 'domain-a', loadChildren: './domain-a/domain-a.module#DomainAModule' },
  { path: 'domain-b', loadChildren: './domain-b/domain-b.module#DomainBModule' },
  { path: '', component: DashbordComponent, pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
