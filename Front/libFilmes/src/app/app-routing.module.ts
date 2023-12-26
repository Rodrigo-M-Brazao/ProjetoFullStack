import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { CadastroFilmeComponent } from './views/cadastro-filme/cadastro-filme.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'cadastro-filme', component: CadastroFilmeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
