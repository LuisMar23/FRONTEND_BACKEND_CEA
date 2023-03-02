import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'acceso',
    loadChildren: () =>
      import('./modules/acceso/acceso.module').then((m) => m.AccesoModule),
  },
  {
    path: 'logout',
    loadChildren: () =>
      import('./modules/logout/logout.module').then((m) => m.LogoutModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
