<?php

class Mois
{
    // Déclaration des propriétés de la classe
    public $jours = ["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"];
    private $tmois = ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"];
    public $mois;
    public $annee;

    /**
     * Month constructor
     * @param int $mois : Le mois compris entre 1 et 12
     * @param int $annee : L'année
     * @throws Exception
     */
    public function __construct(?int $mois = null, ?int $annee = null)
    {
        if ($mois === null || $mois < 1 || $mois > 12) {
            $mois = intval(date("m"));
        }

        if ($annee === null) {
            $annee = intval(date("Y"));
        }
        
        $this->mois = $mois;
        $this->annee = $annee;
    }

    /**
     * Fonction permettant de renvoyer la valeur du mois et de l'année
     * @return string
     */
    public function toString(): string
    {
        return $this->tmois[$this->mois - 1] . " " . $this->annee;
    }

    public function getWeeks(): int
    {
        $start = $this->getStartingDay();
        $end =  (clone $start)->modify("+1 month -1 day");
        $weeks = intval($end->format("W")) - intval($start->format("W")) + 2;
        if ($weeks < 0) {
            $weeks = intval($end->format("W")) + 1;
        }
        return $weeks;
    }

    public function getStartingDay(): DateTime
    {
        return new DateTime("{$this->annee}-{$this->mois}-01");
    }

    public function withinMonth(DateTime $date): bool
    {
        return $this->getStartingDay()->format("Y-m") === $date->format("Y-m");
    }

    public function nextMonth(): Mois
    {
        $mois = $this->mois + 1;
        $annee = $this->annee;
        if ($mois > 12) {
            $mois = 1;
            $annee += 1;
        }
        return new Mois($mois, $annee);
    }

    public function previousMonth(): Mois
    {
        $mois = $this->mois - 1;
        $annee = $this->annee;
        if ($mois < 1) {
            $mois = 12;
            $annee -= 1;
        }
        return new Mois($mois, $annee);
    }
}
